
git pull
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git submodule update --merge

git submodule foreach "git pull"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail




:eof
exit /b 0

:fail 
pause 
exit /b 1