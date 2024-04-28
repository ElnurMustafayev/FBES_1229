sudo docker pull mcr.microsoft.com/mssql/server:2022-latest

docker run mcr.microsoft.com/mssql/server:2022-latest

sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Secret12345!" \
   -p 1433:1433 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest

docker run -d -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Secret12345!" -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest