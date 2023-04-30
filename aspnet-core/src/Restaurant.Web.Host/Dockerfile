FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Restaurant.Web.Host/Restaurant.Web.Host.csproj", "src/Restaurant.Web.Host/"]
COPY ["src/Restaurant.Web.Core/Restaurant.Web.Core.csproj", "src/Restaurant.Web.Core/"]
COPY ["src/Restaurant.Application/Restaurant.Application.csproj", "src/Restaurant.Application/"]
COPY ["src/Restaurant.Core/Restaurant.Core.csproj", "src/Restaurant.Core/"]
COPY ["src/Restaurant.EntityFrameworkCore/Restaurant.EntityFrameworkCore.csproj", "src/Restaurant.EntityFrameworkCore/"]
WORKDIR "/src/src/Restaurant.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Restaurant.Web.Host", "src/Restaurant.Web.Host"]
COPY ["src/Restaurant.Web.Core", "src/Restaurant.Web.Core"]
COPY ["src/Restaurant.Application", "src/Restaurant.Application"]
COPY ["src/Restaurant.Core", "src/Restaurant.Core"]
COPY ["src/Restaurant.EntityFrameworkCore", "src/Restaurant.EntityFrameworkCore"]
WORKDIR "/src/src/Restaurant.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Restaurant.Web.Host.dll"]
