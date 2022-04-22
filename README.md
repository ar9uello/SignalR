# Sacred Valley WEB API


[View Demo](https://sacred-web-dev.applaudostudios.com) ·

[Report Bug](https://applaudostudios.atlassian.net/browse) ·

[Request Feature](https://applaudostudios.atlassian.net/browse) ·

[Jenkins WEB](https://jenkins-2.applaudostudios.com/blue/organizations/jenkins/Sacred%20Valley%2Fsacred-valley-webapp/activity) ·

[Jenkins API](https://jenkins-2.applaudostudios.com/blue/organizations/jenkins/Sacred%20Valley%2Fsacred-valley-api/activity) ·

[Swagger](https://sacred-api-dev.applaudostudios.com/swagger) ·

[Figma](https://www.figma.com/file/DwLfrSPXglVnHm2ZqH8aS0/Sacred-Valley-Capital?node-id=127%3A0) ·

[Sonarqube](https://sonarqube.applaudostudios.com/dashboard?id=sacred-valley-api)


- [Sacred Valley WEB API](#sacred-valley-web-api)

  - [About The Project](#about-the-project)

    - [Built With](#built-with)

  - [Getting Started](#getting-started)

    - [Prerequisites](#prerequisites)

    - [Installation](#installation)

  - [Usage](#usage)

    - [Build](#build)

    - [Start](#start)

    - [Test](#test)

    - [Configuration](#configuration)

      - [Database Connection](#database-connection)

      - [Firebase](#firebase)

  - [Ticket Number](#ticket-number)

  - [Branch Type](#branch-type)

    - [master](#master)

    - [develop](#develop)

    - [release/YYYY.MM.DD.HH](#releaseyyyymmddhh)

    - [feature/SVB-\#\#\#\#](#featuresvb-)

    - [bugfix/SVB-\#\#\#\#](#bugfixsvb-)

    - [hotfix/SVB-\#\#\#\#](#hotfixsvb-)

  - [Contributing](#contributing)


## About The Project


### Built With


- [ASP Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)

- [Identity Server 4](https://identityserver4.readthedocs.io/en/latest/)


And others, check it them in [package.json](package.json)


[(back to top)](#sacred-valley-web-api)


## Getting Started


### Prerequisites


You need have installed

[Git (Latest)](https://git-scm.com), [Specflow](https://docs.specflow.org/projects/getting-started/en/latest/) and

[AWS CLI](https://docs.aws.amazon.com/cli/latest/userguide/getting-started-install.html).


[(back to top)](#sacred-valley-web-api)


### Installation


``` bash

1. Clone the repo


git clone git@bitbucket.org:sacredvalleyteam/sacred-valley-api.git -b develop


cd sacred-valley-api

```


``` bash

2. Assign AWS Keys


AWS Configure


# When executing the AWS Access Key, enter:

Akiaxpqttxqxozhqdhep.

# Then it will ask you for the AWS Secret Access Key, enter:

o7pmzcvcexhzzcforxy0goskvfmyu43se2r5wrfq.

```


[(back to top)](#sacred-valley-web-api)


## Usage


### Build


To build the project just run: `dotnet build`


### Start


To run the project on localhost just run: 


``` ps

dotnet run --project .\SacredValleyAPI\SacredValleyAPI.csproj

```


### Test


To run all tests just run: `dotnet run`


[(back to top)](#sacred-valley-web-api)


### Configuration


In development we usually use and [appsettings](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0#appsettingsjson) file. You can find the configuration needed in this file: `SacredValleyAPI\appsettings.Development.json`.


You also can override this configuration with [enviroment variables](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0#environment-variables)


#### Database Connection


We use these properties to configure the connectio to the database.


``` json

{ 

  "DB_SERVER": "",

  "DB_NAME": "",

  "DB_USERID": "",

  "DB_PASSWORD": ""

}

```


#### Firebase


This section is used to configure the push notification provider. You need to ask for the configuration file to the Android Team. This file is generated in the *service accounts* section on the firebase project configuration.


``` json

{

  "FIREBASE":

  {

    "type": "",

    "projectId": "",

    "privateKeyId": "",

    "privateKey": "",

    "clientEmail": "",

    "clientId": "",

    "authUri": "",

    "tokenUri": "",

    "authProviderX509certUrl": "",

    "clientX509CertUrl": ""

  },

}

```


[(back to top)](#sacred-valley-web-api)


## Ticket Number


The actual format is `SVB-###`, the `###` is a correlative number, example: `SVB-774`.


[(back to top)](#sacred-valley-web-api)


## Branch Type


Read: [git-flow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)


### master


Is the default branch available in the Git repository.

It should be stable all the time and won’t allow any direct check-in.

You can only merge it after code review.


**All team members are responsible for keeping the master stable and up-to-date**.


### develop


Is the main development branch.

The dev branch’s idea is to make changes in it and restrict the developers from making

any changes in the master branch directly. Changes in the dev branch undergo reviews and,

after testing, get merged with the master branch.


### release/YYYY.MM.DD.HH


Is the release branch.

When the develop branch changes are considered stable it

is advisable to create a release branch, then merge the changes into the master branch.


**Always remember to delete this branch once it has been successfully merged in master**.


```

example:


release/2021.10.05.1300

```


### feature/SVB-\#\#\#\#


Is the feature temporary branch.

The bug which needs to be fixed soon, You can only merge it after code review.


**Always remember to delete this branch once it has been successfully merged in develop**.


```

example:


feature/SVB-774

```


### bugfix/SVB-\#\#\#\#


Is the bugfix temporary branch.

For all the new features or improvements, You can only merge it after code review.


**Always remember to delete this branch once it has been successfully merged in develop**.


```

example:


bugfix/SVB-774

```


### hotfix/SVB-\#\#\#\#


Is the hotfix temporary branch.

The all test, You can only merge it after code review.


**Always remember to delete this branch once it has been successfully merged in develop**.


```

example:


hotfix/SVB-774

```


[(back to top)](#sacred-valley-web-api)


## Contributing


1.  Clone the Project,

    **maybe need read about [installation](#installation)**

2.  Create your Branch (`git checkout -b ${BRANCH-TYPE}/${TICKET-NUMBER} ${SOURCE-BRANCH}`),

    **maybe need read about [branches](#branch-type)**

3.  Made your changes

4.  Before stage your changes, run the related tests (`dotnet test`),

    **maybe need read about [tests](#test)**

    <br />

    <br />

    ```text

    🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨

    🚨 If the tests are successful, continue with next steps; 🚨

    🚨 otherwise, you have to fix the tests before continue.  🚨

    🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨 🚨

    ```

    <br />

5.  Stage your Changes (`git add -A`)

6.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)

7.  Push to the Branch (`git push origin ${BRANCH-TYPE}/${TICKET-NUMBER}`)

8.  Open a Pull Request


[(back to top)](#sacred-valley-web-api)
