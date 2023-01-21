FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app/out .
# ENV ConnectionStrings__RestauranteConnection="server=172.17.0.2;port=3306;database=restaurantedb;user=root;password=root"
ENTRYPOINT ["dotnet", "RestauranteService.dll"]