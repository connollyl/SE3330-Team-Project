Team Name: 
	The Brogrammers

Team Members: 
	Dustin Balcerowski
	Nick Buchert 
	Logan Connolly
        Spencer Leutermann
        Daniel Zellmer
        
System Description: 

	Our system will be designed to interact with restaurant customers 
	and administrators in a similar way to the system at Pioneer Haus.
	The system will allow customers to create custom food orders from 
	a selection of items from a table mounted tablet, as well as view 
	wait times for orders/available seating and provide feedback on 
	their specific food/server. The system will assist restaurant 
	administrators by providing access to a recipe repository, which 
	will contain nutrition 	information for all current food items and 
	allow for food entries to be added/removed. Also, the system will 
	generate simple order tickets to allow employees to easily view and 
	produce customer orders, as well as generate order/system statistics 
	to be viewed and analyzed by administrators.

Build Instructions:

	The C# project is to be built in a Visual Studio Environment. 
	1. Open the RestaurantKiosk folder in the src folder
	2. Double click the .csproj file to open up the visual studio project
	   environment.
	3. Click the green start button to build and run Restaurant Kiosk.
	4. To view order statistics, navigate to the following website and select
	file->open db. Then go to \src\RestaurantKiosk\bin\Debug\OrderStatistics.sqlite
	to find the file. Then double click the db and view statistics.
	https://sqliteonline.com/#/
	5. Login information:
		ADMIN USER-> Username & password:admin
		CHEF USER-> Username & password:chef
		GUEST USER-> Username & password:guest

Test Coverage Instructions:
	1. Open the .csproj file in visual studio located in the src folder
	2. Go to "Test"->"Analyze Code Coverage"->"All Tests"
	3. Expand into "restaurantkiosk.exe", then expand "RestaurantKiosk" to see
	code coverage for each class and method.
