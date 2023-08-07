FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Lab2.API/Lab2.API.csproj", "Lab2.API/"]
COPY ["Lab2.Application/Lab2.Application.csproj", "Lab2.Application/"]
COPY ["Lab2.Domain/Lab2.Domain.csproj", "Lab2.Domain/"]
COPY ["Lab2.Infrastructure/Lab2.Infrastructure.csproj", "Lab2.Infrastructure/"]
RUN dotnet restore "Lab2.API/Lab2.API.csproj"
COPY . .
WORKDIR "/src/Lab2.API"
RUN dotnet build "Lab2.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lab2.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lab2.API.dll"]
