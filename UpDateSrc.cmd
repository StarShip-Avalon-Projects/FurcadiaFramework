
git.exe pull --recurse-submodules=yes
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

bin\nuget.exe restore
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:eof

exit /b 0


:fail 

pause 

:exit /b 1