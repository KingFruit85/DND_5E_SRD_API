# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /DND_5E_SRD_API

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY ../ ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /DND_5E_SRD_API
COPY --from=build-env /DND_5E_SRD_API/out .
ENTRYPOINT ["dotnet", "DND_5E_SRD_API.dll"]