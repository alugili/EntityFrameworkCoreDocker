FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

EXPOSE 32034

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["EntityFrameworkSQLite/EntityFrameworkSQLite.csproj", "EntityFrameworkSQLite/"]
RUN dotnet restore "EntityFrameworkSQLite/EntityFrameworkSQLite.csproj"
COPY . .
WORKDIR "/src/EntityFrameworkSQLite"
RUN dotnet build "EntityFrameworkSQLite.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EntityFrameworkSQLite.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EntityFrameworkSQLite.dll"]