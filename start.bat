@echo off
echo Stopping and removing existing container...
docker stop aikaseggs-test 2>nul
docker rm aikaseggs-test 2>nul

echo Building Docker image...
docker build -t aikaseggs:local .

echo Starting container...
docker run -d -p 8080:8080 -e PORT=8080 --name aikaseggs-test aikaseggs:local

timeout /t 2 /nobreak >nul

echo.
echo Container started! Showing logs (Ctrl+C to exit):
echo ================================================
docker logs -f aikaseggs-test

