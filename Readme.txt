This project demonstrates 3 layer architecture. It's a simple toy store application. This administration portion is coded in C# WinForms. For this current version, user can search and do typical database CRUD (create, read, update, delete) functions on customer, and product modules. Order management module will be implemented in the near future after the development of the storefront website (using ASP.Net). User can also run report on product and customer on this version as well.
The main purpose of this project is to put various code snippets into a collection of codes for education and references. Hopefully, they are very useful to many beginning level C# programmers(and hopefully intermediate level as well). The code is written in C# using Visual Studio 2013, .NET framework 4.5. Database is written for MS SQL Server 2014. Report is written using SAP Crystal Report for .NET engine version 13. I tried to put as little UI validations on the codes as necessary. So please feel free to add more on your own. Here's the list of some features:

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
	Visual Studio IDE
- Breaking whole WinForms solution into several projects So it would be easier for each team member to work on different module.
- Managing multiple panels on a WinForms menu.
- Binding DataTable to DataGridView and display only selected columns.
- Utilizing OpenFileDialog class.
- Loading pictureBox with an image selected from a result of OpenFileDialog.
- Converting image to byte array using FileStream class.
- Creating Crystal report, setting display columns, header, details, and footer.
- Programmatically call the report and display it in WinForms application using CrystalReportViewer.

Instruction:
1. Download and install SAP Crystal Report for .NET from http://www.sap.com/solution/sme/software/analytics/crystal-visual-studio/index.html
2. Create a database "TinToy", by executing the script "TinToy.sql"
3. Unzip the attached file and open TinToy/TinToy.sln
 
////////
Todo:
1. Pagination on grid
2. Display side image based on selected value in a gridview.
////////

Please feel free to copy this code and use it as you please. Credit to all programmers on codeproject.com, stackoverflow.com, planet-source-code.com. Love you guys. Any questions, suggestions please write me at zybermaniac@yahoo.com Enjoy and have a nice day.