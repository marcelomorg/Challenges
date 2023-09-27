# docker container with service
docker service create --name servicename -p 9090:80 --replicas=6 nginx
