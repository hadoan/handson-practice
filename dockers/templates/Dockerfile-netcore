FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src

COPY scripts scripts/

COPY /aspnet-core/src/*/*.csproj /src/csproj-files/

COPY . .
WORKDIR /src/aspnet-core/src/KonbiCloud.Web.Host
RUN dotnet publish -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KonbiCloud.Web.Host.dll"]
