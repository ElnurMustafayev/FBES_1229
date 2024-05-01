FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . . 
RUN dotnet publish -c Release -o dist

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS runtime
WORKDIR /app
COPY --from=build /src/dist .
ENTRYPOINT [ "dotnet", "ConsoleApp.dll" ]