docker run -d --rm -p 6379:6379 --name redisdb redis

docker exec -it redisdb redis-cli