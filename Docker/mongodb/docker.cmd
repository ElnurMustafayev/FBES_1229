docker pull mongo

docker run -p 27017:27017 -v myvolume:/data/db -v myvolume:/data/configdb --rm -d --name mongodb --network mynetwork mongo

docker run -p 8080:8080 --rm -d --name webapiapp --network mynetwork webapi