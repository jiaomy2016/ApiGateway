#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim 
RUN mkdir -p /opt/web/api1
WORKDIR /opt/web/api1
EXPOSE 5000
COPY . /opt/web/api1
ENTRYPOINT ["dotnet", "Api1.dll"]
