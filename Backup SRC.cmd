
git pull
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git submodule update -f --merge
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git submodule foreach "git pull"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

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
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git commit -m"Auto Version Update" --all
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 


git submodule foreach "git add --all"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git submodule foreach "git commit -ma'Auto Update SubModules'"
# set GIT_STATUS=%ERRORLEVEL% 
# if not %GIT_STATUS%==0 goto fail 

git submodule foreach "git push -f origin HEAD:master"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git push -f --all --recurse-submodules=on-demand
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git request-pull master https://github.com/StarShip-Avalon-Projects/FurcadiaFramework.git