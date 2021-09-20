
# netChallenge

I was asked to design and build an application that allows several users to talk in a chatroom and also to get stock quotes
from an API using a specific command.

# Tecnical Summary

- The project consists of four microservices each of them is designed with a clean architecture. 
  - Each microservice is responsible for:
    1. Login management
    2. API responsible for managing chat messages
    3. Bot responsible for obtaining data from stooq.com site, parsing information, and sending messages to chat
    4. User interface made with Blazor
- Communication between services is done with RabbitMQ
- The DB is in the cloud. 
- This project use Swagger for documentation. 
- Each microservice has its own DockerFile. 
- There is a tests folder where the unit tests are. 

## Instalation

### Clone this project, run:
    - git clone https://github.com/ar9uello/netChallenge.git

### Move to the folder project, run:
    - cd netChallenge

### Start docker containers, run:
    - docker-compose up

## Documentation

You can see swagger documentation in the following links:
- http://localhost:7001/swagger
- http://localhost:7002/swagger


## Project Requirements



## Unit tests

![](./images/Tests.png)
