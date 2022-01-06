

* ADDING CERTIFICATTE FOR HTTPS:
------------------------------
dotnet dev-certs https

* TRUSTING

* ADDING NUGET PACKAGE MANAGER:
-------------------------------
>>Add Microsoft.EntityFrameworkCore.SqlLite or SqlServer
Note: Good to match EF version with .Net version

* ADDING CONNECION STRINGS:
---------------------------
appsetttings.Development.json
>>   "ConnectionStrings": {
    "DefaultConnection": "Data source=skinet.db"
  }

* PREPARING MIGRATION:
----------------------  
dotnet tool install --global dotnet-ef --version 5.0.4
// To update
dotnet tool update --global dotnet-ef --version 5.0.4


* INITIATE MIGARTION:
---------------------
install Microsoft.EntityFramwworkCore.Design


dotnet ef migrations add <name_the_migration> -o Data/Migrations

Note: 
In migration the Down method is called on updating the database(model change etc)

* CREATING DATABASE : 
---------------------
dotnet ef database update
