#!/bin/bash
export ASPNETCORE_ENVIRONMENT=local
DOTNET_RUN=./.NETCoreMicroservice101/dotnet-run.sh

REPOSITORIES=(Customer.API Products.API Orders.API APIGateway)

for REPOSITORY in ${REPOSITORIES[*]}
do
	 echo ========================================================
	 echo Starting a service: $REPOSITORY
	 echo ========================================================
     cd $REPOSITORY
     $DOTNET_RUN &
     cd ..
done