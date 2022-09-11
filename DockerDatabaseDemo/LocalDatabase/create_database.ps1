[string]$name = "DockerDatabaseDemoDB"

Write-Output "Generating setup.sql script"
dotnet ef migrations script -p ../DockerDatabaseDemo.csproj --output ./sql/setup.sql --context StoreContext --idempotent

@("CREATE DATABASE [$name];", "GO", "USE [$name];") + (Get-Content ./sql/setup.sql) | Set-Content ./sql/setup.sql

get-content ./sql/setup.sql

Write-Output "Starting docker build"
docker build -t demo_db --file .\Dockerfile --progress=plain .

docker images