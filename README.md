# BookListRazor
ASP .NET Core Razor Page based app
Just a demo project for demonstrating CRUD operations with ASP .NET Core and Razor pages and MVC
Also uses sweet alert and toastr messages and data tables.Check them out below
https://datatables.net/
https://cdnjs.com/libraries/toastr.js/latest
https://sweetalert.js.org/guides/

Also have to install several packages

1) Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation: Runtime compilation support for Razor views and Razor Pages in ASP.NET Core MVC.
2) Microsoft.EntityFrameworkCore: Entity Framework Core is a lightweight and extensible version of the popular Entity Framework data access technology.
3) Microsoft.EntityFrameworkCore.SqlServer: Microsoft SQL Server database provider for Entity Framework Core.
4) Microsoft.EntityFrameworkCore.Tools: Entity Framework Core Tools for the NuGet Package Manager Console in Visual Studio.

Run the following commands to import your EF classes to DB
1. add-migration AddBooksToDB
2. update-database
