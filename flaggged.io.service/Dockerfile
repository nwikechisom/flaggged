FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["flaggged.io.service/flaggged.io.service.csproj", "flaggged.io.service/"]
RUN dotnet restore "flaggged.io.service/flaggged.io.service.csproj"
COPY . .
WORKDIR "/src/flaggged.io.service"
RUN dotnet build "flaggged.io.service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "flaggged.io.service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "flaggged.io.service.dll"]
