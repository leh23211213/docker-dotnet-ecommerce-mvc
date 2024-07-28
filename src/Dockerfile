# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/src.csproj", "./"]
RUN dotnet restore "./src.csproj"
COPY . .
RUN dotnet build "src.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "src.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Development stage (optional, for development purposes)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS development
COPY . /source
WORKDIR /source/src
CMD dotnet run --no-launch-profile

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "src.dll"]
