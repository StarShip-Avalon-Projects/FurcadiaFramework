
git.exe add --all
git.exe submodule foreach "git.exe add --all || true"
rem set git.exe_STATUS=%ERRORLEVEL% 
rem if not %git.exe_STATUS%==0 goto eof 

git.exe submodule foreach "git.exe commit -am'Auto Update SubModules' || true"
git commit -am"Auto Update SubModules"
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

git push --recurse-submodules=on-demand
set GIT_STATUS=%ERRORLEVEL% 
if %GIT_STATUS%==0 goto eof

git push
set GIT_STATUS=%ERRORLEVEL% 
if not %GIT_STATUS%==0 goto fail 

:eof
exit /b 0
:fail
pause
exit /b 1