call UpdateSrc.cmd
set BUILD_STATUS=%ERRORLEVEL% 
if not %BUILD_STATUS%==0 goto fail 

IF "%~1"=="" GOTO BuildAll
IF "%~1"=="VersionBump" GOTO VersionBump

:VersionBump
msbuild /t:IncrementVersions;BuildAll  Solution.build
set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto BuildRelease 
if not %BUILD_STATUS%==0 goto fail 
 
:BuildAll
msbuild /t:BuildAll  Solution.build
set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto BuildRelease 
if not %BUILD_STATUS%==0 goto fail 

:BuildRelease
 msbuild /t:Build /property:Configuration=Release Solution.build
 set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto end 
if not %BUILD_STATUS%==0 goto fail 
 
:fail 
pause 
exit /b 1

:End

"Send Update.cmd"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto eof

:pull
call PullRequest.cmd

:eof
exit /b 0