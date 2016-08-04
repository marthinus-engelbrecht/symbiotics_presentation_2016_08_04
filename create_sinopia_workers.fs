#! /usr/local/bin/fish

for i in (seq 1 $argv[1])
	docker-machine create --driver digitalocean --engine-label "type=sinopia" --digitalocean-image ubuntu-16-04-x64 --digitalocean-access-token=$access_token --digitalocean-size 512mb --swarm --swarm-discovery token://$swarm_token worker-$i
end
