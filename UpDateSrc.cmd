
git.exe pull --recurse-submodules=on-demand
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:NuGetRestore

bin\nuget.exe update -self
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

bin\nuget.exe restore FurcadiaFramework.sln
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:eof
exit /b 0

:fail 
pause 
exit /b 1