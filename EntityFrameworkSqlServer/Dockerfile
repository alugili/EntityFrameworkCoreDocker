FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

EXPOSE 32033

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["EntityFrameworkSqlServer.csproj", "./"]
RUN dotnet restore "/EntityFrameworkSqlServer.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "EntityFrameworkSqlServer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EntityFrameworkSqlServer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EntityFrameworkSqlServer.dll"]
