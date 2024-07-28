#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV SimpleProperty="BASE-dockerfile"

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["../src/src.csproj", "."]
RUN dotnet restore "src/src.csproj"
COPY ../src/. .
RUN dotnet build "src.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "src.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Development stage for local testing
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS development
COPY .. /source
WORKDIR /source/src
CMD dotnet run --no-launch-profile

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV SimpleProperty="FINAL-dockerfile"
ENTRYPOINT ["dotnet", "src.dll"]
