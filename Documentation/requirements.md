# genny the code generator

- [X] (R001) This is a ui application
- [X] (R002) There is a way to enter a connection string

I have modified the idea, so that there is a dropdown box. I thought maybe it is better just to show "names" instead of full connection strings. I also do not want to enter connection strings in the application. They should be provided by a configuration mechanism.

- [ ] (R003) The application displays a searchable list of database views and tables
- [X] (R004) There is an update button that rereads all database objects from the database

Although I do not have added real database access I have changed this requirement, too. In Blazor you use data binding. That means that you can actually track, when the user changes the selection in the drop down with the connection names. And this again means, that I can use the event of the change to load the database objects.

- [ ] (R005) When an object is selected the following c# snippets are displayed in a source text window:
  - [ ] (R006) a repository interface with some basic operations
  - [ ] (R007) a repository class
  - [ ] (R008) an entity interface
  - [ ] (R009) an entity class
  