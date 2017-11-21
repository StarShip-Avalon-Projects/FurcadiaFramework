
git.exe pull --recurse-submodules=on-demand
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

bin\nuget.exe restore
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:NuGetRestore
bin\nuget.exe restore

:eof
exit /b 0

:fail 
pause 
exit /b 1