@echo off

echo "windows docker build"

cd ./Api1

dotnet publish -c Release -o ../publish

cd ../publish

echo "dotnet publish success"

docker build -t api1 .