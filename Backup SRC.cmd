
git pull --all
IF "%~1"=="" GOTO BuildAll
IF "%~1"=="VersionBump" GOTO VersionBump

:VersionBump
msbuild /t:IncrementVersions;BuildAll  Solution.build
goto :End

:BuildAll
msbuild /t:BuildAll  Solution.build

:End