#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StudentServer.Web/StudentServer.Web.csproj", "StudentServer.Web/"]
COPY ["StudentServer.Application/StudentServer.Application.csproj", "StudentServer.Application/"]
COPY ["StudentServer.Domain/StudentServer.Domain.csproj", "StudentServer.Domain/"]
COPY ["StudentServer.Infra/StudentServer.Infra.csproj", "StudentServer.Infra/"]
RUN dotnet restore "StudentServer.Web/StudentServer.Web.csproj"
COPY . .
WORKDIR "/src/StudentServer.Web"
RUN dotnet build "StudentServer.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StudentServer.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudentServer.Web.dll"]