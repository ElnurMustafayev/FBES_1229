FROM mcr.microsoft.com/dotnet/sdk:7.0

WORKDIR /src

COPY . .

RUN dotnet publish -c Release -o dist

ENTRYPOINT [ "dotnet", "./dist/ConsoleApp.dll" ]