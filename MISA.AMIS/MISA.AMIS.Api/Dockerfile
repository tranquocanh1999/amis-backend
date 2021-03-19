#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["MISA.AMIS.Api/MISA.AMIS.Api.csproj", "MISA.AMIS.Api/"]
RUN dotnet restore "MISA.AMIS.Api/MISA.AMIS.Api.csproj"
COPY . .
WORKDIR "/src/MISA.AMIS.Api"
RUN dotnet build "MISA.AMIS.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MISA.AMIS.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MISA.AMIS.Api.dll"]