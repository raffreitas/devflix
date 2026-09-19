FROM mcr.microsoft.com/dotnet/aspnet:10 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Devflix.Content.Admin.Api/Devflix.Content.Admin.Api.csproj", "src/Devflix.Content.Admin.Api/"]
COPY ["src/Devflix.Content.Admin.Application/Devflix.Content.Admin.Application.csproj", "src/Devflix.Content.Admin.Application/"]
COPY ["src/Devflix.Content.Admin.Domain/Devflix.Content.Admin.Domain.csproj", "src/Devflix.Content.Admin.Domain/"]
COPY ["src/Devflix.Content.Admin.Infra.Data.EF/Devflix.Content.Admin.Infra.Data.EF.csproj", "src/Devflix.Content.Admin.Infra.Data.EF/"]
COPY ["src/Devflix.Content.Admin.Infra.Messaging/Devflix.Content.Admin.Infra.Messaging.csproj", "src/Devflix.Content.Admin.Infra.Messaging/"]
COPY ["src/Devflix.Content.Admin.Infra.Storage/Devflix.Content.Admin.Infra.Storage.csproj", "src/Devflix.Content.Admin.Infra.Storage/"]
RUN dotnet restore "src/Devflix.Content.Admin.Api/Devflix.Content.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/Devflix.Content.Admin.Api"
RUN dotnet build "./Devflix.Content.Admin.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Devflix.Content.Admin.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Devflix.Content.Admin.Api.dll"]
