function createHaproxyWorkers 

	echo "Creating HAproxy workers" 

	set command "docker-machine create --driver digitalocean --engine-label type=haproxy --digitalocean-image ubuntu-16-04-x64 --digitalocean-access-token=$access_token --digitalocean-size 512mb --swarm --swarm-discovery token://c1190b21c78917c82aa944e1c291f302 haproxy-worker"

	echo 
	echo $command
	echo 
	
	eval $command
end 

createHaproxyWorkers
