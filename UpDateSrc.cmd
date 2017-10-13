
git fetch --recurse-submodules=on-demand
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:eof
exit /b 0

:fail 
pause 
exit /b 1
exit /b 1