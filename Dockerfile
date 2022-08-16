FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build

WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY RestierServiceV2/*.csproj ./RestierServiceV2/
COPY RestierServiceV2/*.config ./RestierServiceV2/
RUN nuget restore

# copy everything else and build app
COPY RestierServiceV2/. ./RestierServiceV2/
WORKDIR /app/RestierServiceV2
RUN msbuild /p:Configuration=Debug -r:False


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/RestierServiceV2/. ./