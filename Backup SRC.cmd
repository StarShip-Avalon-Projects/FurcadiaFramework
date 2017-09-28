
git pull
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git submodule update -f --merge

git submodule foreach "git pull"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

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
git add --all
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto eof 

git commit -m"Auto Version Update" --all
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto eof 


git submodule foreach "git add --all"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto eof 

git submodule foreach "git commit -ma'Auto Update SubModules'"

git push --all --recurse-submodules=on-on-demand
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto eof  

git request-pull master https://github.com/StarShip-Avalon-Projects/FurcadiaFramework.git

:eof
exit /b 0