#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
ENV DOTNET_URLS=http://+:3000
ENV DOTNET_URLS=https://+:3001
EXPOSE 3000
EXPOSE 3001


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Store2022Microservice/Store2022Microservice.csproj", "Store2022Microservice/"]
RUN dotnet restore "./Store2022Microservice/Store2022Microservice.csproj"
COPY . .
WORKDIR "/src/Store2022Microservice"
RUN pwd
RUN ls -la
RUN dotnet build "./Store2022Microservice.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Store2022Microservice.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Store2022Microservice.dll"]