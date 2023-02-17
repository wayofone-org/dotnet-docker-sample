FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder

ARG Version
WORKDIR /src

COPY . ./dotnet-sample

WORKDIR /src/dotnet-sample/src
RUN dotnet restore dotnet-sample.csproj
RUN dotnet build /p:Version=$Version -c Release --no-restore  dotnet-sample.csproj
RUN dotnet pack /p:Version=$Version -c Release --no-restore --no-build  dotnet-sample.csproj

