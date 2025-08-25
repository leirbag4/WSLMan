set /p VERSION_NUMBER=Version Number: 

SET ORIGINAL_RELEASE_DIR="..\WSLMan\bin\Release\net7.0-windows"
SET NEW_RELEASE_DIR=".\WSLMan"
SET ZIP_NAME="wslman-ver-%VERSION_NUMBER%.zip"

xcopy /y /e /i %ORIGINAL_RELEASE_DIR% %NEW_RELEASE_DIR%

powershell -NoProfile -ExecutionPolicy Bypass -File "_create_release_.ps1"
rmdir /s /q %NEW_RELEASE_DIR%

ren "WSLMan.zip" %ZIP_NAME%


pause