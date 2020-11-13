FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.8-bionic AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.8-bionic AS build

ARG BUILD

WORKDIR /source
# copy csproj and restore as distinct layers
COPY . .

RUN dotnet publish -c Release -o /app

# final stage/image
FROM base AS final
COPY --from=build /app .
COPY cert.pfx /app

ENTRYPOINT ["dotnet", "Sample.Api.dll"]