#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p b746c80e-aa92-4279-882c-28b6c915964d -t
    fi
    cd ../
fi

docker-compose up -d
