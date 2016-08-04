function createManager 
	set command "docker-machine create --driver digitalocean --digitalocean-image ubuntu-16-04-x64 --digitalocean-access-token=4c12a3139467d386ba5759dbad63e53d087834aa18d523bcf4c22a93c9a250c4 --digitalocean-size 512mb --swarm --swarm-master --swarm-discovery token://c1190b21c78917c82aa944e1c291f302 manager"
	echo
	echo $command
	echo
	eval $command
end

createManager
