#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p b2efad74-4cbb-44f6-ae4b-3c182bff8724 -t
    fi
    cd ../
fi

docker-compose up -d
