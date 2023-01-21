FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o out

WORKDIR /app/out

ENV ConnectionStrings__RestauranteConnection="server=restaurante-db;port=3306;database=restaurantedb;user=root;password=root"

ENTRYPOINT ["dotnet", "RestauranteService.dll"]