This project demonstrates 3 layer architecture. It's a simple toy store application. Administration portion is coded in C# WinForms (http://www.planet-source-code.com/vb/scripts/ShowCode.asp?txtCodeId=9495&lngWId=10). Order management module will be implemented in the near future after the completion of the development of the storefront website (using ASP.Net).
The main purpose of this project is to put various code snippets into a collection of codes for education and references. Hopefully, they are very useful to many beginning level C# programmers (and hopefully intermediate level as well). The code is written in ASP.NET/C# using Visual Studio 2013, .NET framework 4.5. Here's the list of some features:

	Value Object
- Generic/common class was made to carry error messages.
- Separating each module such as Customer, Product into its own class and its own file for the ease of code management.
- Creating the ADO.NET Entity Data Model using Entity Framework. 
- Utilizing properties (get/set accessor) to represent columns of the table. 
	Data Access Object
- Putting together connection string for SQL Server database in app.config file.
- Utilizing SQLcommand, SQLDataAdapter, and SQLConnection class (ADO.NET).
- Extracting readable error messages from exception stack trace.
- Writing characters (error messages) to a stream and output to a file.
- Technique of putting parameters together to form where clause for select statement.
	Business Object
- Manipulating DataSet, DataTable, and DataRow (ADO.NET)
- Differentiate between business logic errors and data accessing errors. Catch and send them appropriate places.
- Technique of bubbling error messages from data access layer up to business layer, and to presentation layer.
	ASP.NET
- Breaking whole WebForms solution into several projects so it would be easier for each team member to work on different module.
- For the sake of simplicity, a database object is created inside the solution. And it is placed inside App_Data folder.
- Demonstrated the use of web template. Utilizing the pre-made css.
- Incorporated the web template into WebForms master page.
- Manipulating content place holder blocks of the ASP page dynamically.
- Utilized RequiredFieldValidator, along with the use of ControlToValidate, and ErrorMessage.
- Demonstrated the use of Http Page session, and response.redirect().
- Demonstrated the use of Http Handler for retrieving images.
- Demonstrated the use of GridView along with paging and sorting.

Instruction:
Unzip the attached file and open TinToyWeb/TinToyWeb.sln

You can view the working sample online at http://zyber.somee.com/ Both admin and storefront solutions are also on github.com/zybermaniac/TinToyAdmin 
Please feel free to copy this code and use it as you please. Credit to all programmers on codeproject.com, stackoverflow.com, planet-source-code.com. Love you guys. Any questions, suggestions please write me at zybermaniac@yahoo.com Enjoy and have a nice day.