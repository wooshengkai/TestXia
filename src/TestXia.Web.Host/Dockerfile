FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/TestXia.Web.Host/TestXia.Web.Host.csproj", "src/TestXia.Web.Host/"]
COPY ["src/TestXia.Web.Core/TestXia.Web.Core.csproj", "src/TestXia.Web.Core/"]
COPY ["src/TestXia.Application/TestXia.Application.csproj", "src/TestXia.Application/"]
COPY ["src/TestXia.Core/TestXia.Core.csproj", "src/TestXia.Core/"]
COPY ["src/TestXia.EntityFrameworkCore/TestXia.EntityFrameworkCore.csproj", "src/TestXia.EntityFrameworkCore/"]
WORKDIR "/src/src/TestXia.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TestXia.Web.Host", "src/TestXia.Web.Host"]
COPY ["src/TestXia.Web.Core", "src/TestXia.Web.Core"]
COPY ["src/TestXia.Application", "src/TestXia.Application"]
COPY ["src/TestXia.Core", "src/TestXia.Core"]
COPY ["src/TestXia.EntityFrameworkCore", "src/TestXia.EntityFrameworkCore"]
WORKDIR "/src/src/TestXia.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TestXia.Web.Host.dll"]
