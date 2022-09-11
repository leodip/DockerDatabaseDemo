[string]$name = "DockerDatabaseDemoDB"
[string]$cID = $(docker ps -aqf "name=$name")
[string]$dbPassword = "Password@123"

if($cID)
{
	$cID = $(docker ps -qf "name=$name")
	if($cID)
	{
		Write-Output "The container $name is already running with ID: $cID";
	}
	else
	{
		Write-Output "The container $name already exists, but is stopped. Will start it.";
		docker start $name
	}		
}
else 
{
	Write-Output "Starting container $name";
	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$dbPassword' --name $name -p 14331:1433 -d demo_db
}

$newline = [Environment]::NewLine

Write-Output $newline
docker ps

Write-Output $newline
Write-Output "Connection string:"
Write-Output "server=tcp:localhost,14331; database=$name; Persist Security Info=false; User Id=sa; Password=$dbPassword; MultipleActiveResultSets=false; TrustServerCertificate=true;"