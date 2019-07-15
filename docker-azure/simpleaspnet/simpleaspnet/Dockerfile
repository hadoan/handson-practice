FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["simpleaspnet/simpleaspnet.csproj", "simpleaspnet/"]
RUN dotnet restore "simpleaspnet/simpleaspnet.csproj"
COPY . .
WORKDIR "/src/simpleaspnet"
RUN dotnet build "simpleaspnet.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "simpleaspnet.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "simpleaspnet.dll"]