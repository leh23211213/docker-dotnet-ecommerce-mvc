#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV SimpleProperty="BASE-dockerfile"

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/src.csproj", "src/"]
RUN dotnet restore "src/src.csproj"
COPY . .
WORKDIR "/src/src"
RUN dotnet build "src.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV SimpleProperty="FINAL-dockerfile"
ENTRYPOINT ["dotnet", "src.dll"]
