# HaloOnline.Server

## This is a backend emulator for Halo Online. It's unmaintained, I have no plans to continue Atvaark's work.

This was an emulator for the Halo Online official backend. The idea was to emulate it to provide matchmaking and the various other web services seen in the Halo Online client.

I have preserved a copy of the old Trello Board so that information he gathered is available [Trello board](https://trello.com/b/0edxBOLD/halo-online-backend).

## Requirements
* Visual Studio 2013
* .NET Framework 4.5

## Projects

### HaloOnline.Server
A console application that hosts the webserver, the webservice and the log server.

### HaloOnline.Server.App
An AngularJS single page web application for managing the server.

### HaloOnline.Server.Common
An assembly for storing common types.

### HaloOnline.Server.Core.Http
An http webservice which handles authentication and gives external access to game data.

### HaloOnline.Server.Core.Repository
A database access layer for storing and retrieving data.

### HaloOnline.Server.Core.Log
A socket based log service.

### HaloOnline.Server.Model
An assembly containing the data model of the server.

## Frameworks and dependencies
* OWIN - Web server interface
* ASP.NET Web Api - HTTP webservice framework
* Autofac - Inversion of Control container
* OAuth - Authorization
* JSON Web Tokens - Bearer token format
* SQLite - Database
* Entity Framework - Object-relational mapper

## Getting started

* Compile the solution
* Deploy HaloOnline.Server.App
* Run HaloOnline.Server
* Open %HALODIR%\game.cfg
  * Edit EndpointsDispatcherDomain and EndpointsDispatcherPort
  * Edit AzureBinLogEndPoint
* Open %HALODIR%\maps\tags.dat
  * Swap the enum values of BACKEND_SESSION_ESTABLISHING and BACKEND_SESSION_ONLINE
  
* Optional
  * Compile a version of ElDorito that doesn't mess with account related values

## Todo list

* ~~Creating an assembly for storing persistent data with Entity Framework~~
* Creating an assembly for non persistent data like Chat, Presence, Parties and Matchmaking
* Waiting for a functional client
