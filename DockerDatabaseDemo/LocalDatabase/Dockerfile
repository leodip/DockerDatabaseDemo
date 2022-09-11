FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Password@123
ENV MSSQL_PID=Developer
ENV MSSQL_TCP_PORT=1433 

USER root

COPY ./sql/setup.sql /tmp/setup.sql

RUN ( /opt/mssql/bin/sqlservr & ) | grep -q "Service Broker manager has started" && sleep 2s \
 && echo 'Will apply script setup.sql...' \ 
 && /opt/mssql-tools/bin/sqlcmd -U sa -P Password@123 -i /tmp/setup.sql