# Whose Turn

A simple web app to track whose turn it is to do chores/pay bills/etc. Hopefully currently deployed to [whoseturnisit.azurewebsites.net](http://whoseturnisit.azurewebsites.net/).

An API is provided in addition to the web app to enable integration from other applications (including hopefully mobile).

### To build

 - Clone the project
 - Update the Web.config of the API and Web project to point to a MSSQL instance
 - Run the app (the database schema should be automatically created/migrated)
 
### Limitations

 - There is currently no way to create people, groups, or tasks; these must be bootstrapped
 - There is no user authentication
