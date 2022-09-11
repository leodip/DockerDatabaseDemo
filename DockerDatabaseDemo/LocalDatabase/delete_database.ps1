[string]$name = "DockerDatabaseDemoDB"

docker ps

docker stop $name

docker rm $name

docker ps -a