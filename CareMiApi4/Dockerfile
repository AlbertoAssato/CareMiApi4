# Imagem base do runtime .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Imagem base do SDK .NET 8 para construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
COPY . /src
WORKDIR /src
RUN ls
RUN dotnet build "CareMiNet.csproj" -c Release -o /app/build

# Publicação da aplicação
FROM build AS publish
RUN dotnet publish "CareMiNet.csproj" -c Release -o /app/publish

# Configuração final para o runtime da aplicação
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CareMiNet.dll"]
