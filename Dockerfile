FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Install clang/zlib1g-dev dependencies for publishing to native
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
    clang zlib1g-dev

ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy solution and project files
COPY ["AikaSeggs.sln", "."]
COPY ["AikaSeggs/AikaSeggs.csproj", "AikaSeggs/"]
COPY ["AikaSeggs.GameServer/AikaSeggs.GameServer.csproj", "AikaSeggs.GameServer/"]
COPY ["AikaSeggs.Common/AikaSeggs.Common.csproj", "AikaSeggs.Common/"]
COPY ["AikaSeggs.Database/AikaSeggs.Database.csproj", "AikaSeggs.Database/"]
COPY ["AikaSeggs.PcapParser/AikaSeggs.PcapParser.csproj", "AikaSeggs.PcapParser/"]
COPY ["AikaSeggs.PrivateClient/AikaSeggs.PrivateClient.csproj", "AikaSeggs.PrivateClient/"]

RUN dotnet restore "./AikaSeggs.GameServer/AikaSeggs.GameServer.csproj"

COPY . .

WORKDIR "/src/AikaSeggs.GameServer"
RUN dotnet build "./AikaSeggs.GameServer.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AikaSeggs.GameServer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=true

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080

# Copy published files
COPY --from=publish /app/publish .

# Copy Resources folder from project root
COPY --from=build /src/Resources ./Resources

ENTRYPOINT ["dotnet", "AikaSeggs.GameServer.dll"]

