#! /usr/local/bin/fish

set worker_count $argv[1]
echo -n "Creating sinopia workers: "  
echo $worker_count

for i in (seq 1 $worker_count)
	set command " docker-machine create --driver digitalocean --engine-label "type=sinopia" --digitalocean-image ubuntu-16-04-x64 --digitalocean-access-token=$access_token --digitalocean-size 512mb --swarm --swarm-discovery token://$swarm_token worker-$i"
	echo 
	echo $command
	echo 
	
	eval $command
end
