
git pull
git submodule update -f --merge
IF "%~1"=="" GOTO BuildAll
IF "%~1"=="VersionBump" GOTO VersionBump

:VersionBump
msbuild /t:IncrementVersions;BuildAll  Solution.build
set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto end 
if not %BUILD_STATUS%==0 goto fail 
 
:BuildAll
msbuild /t:BuildAll  Solution.build
set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto end 
if not %BUILD_STATUS%==0 goto fail 
 
:fail 
pause 
exit /b 1

:End
git add --all
git commit -m"Auto Version Update and Update Docs" --all

git submodule foreach "git add --all"
git submodule foreach "git commit -m'Auto Update SubModules'-a"
git submodule foreach "git push -f origin HEAD:master"
git push -f --all --recurse-submodules=on-demand

git request-pull master https://github.com/StarShip-Avalon-Projects/FurcadiaFramework.git