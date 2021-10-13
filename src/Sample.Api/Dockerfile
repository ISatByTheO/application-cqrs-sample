FROM mcr.microsoft.com/dotnet/aspnet:5.0.6-buster-slim AS base

#The following lines are needed to allow Tls 1.0
#since our sql servers don't support Tls 1.2
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /usr/lib/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /usr/lib/ssl/openssl.cnf

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0.300-buster-slim AS build

ARG BUILD

WORKDIR /src

COPY . .

RUN dotnet publish -c Release -o /app

# final stage/image
FROM base AS final

COPY --from=build /app .

ENTRYPOINT ["dotnet", "Sample.Api.dll"]