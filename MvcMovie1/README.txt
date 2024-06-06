Balu Madhukumar(0856681)
Web app created w/ VS2022 .NET 7


Recreated the ASP .NET MVC Core application
Using .Net 7,no authentication

1329
Ran the program, Confirmed the default works:
https://localhost:7129/
Modified the index.cshtml title to MVC MOVIE by replacing the default title WELCOME
I have created README.txt for documentation purpose.
then run the application again to reconfirm the changes applied.


1335
Then started part2 using documentation.
Part2 - Add a Controller

1400
I have added new index method and changed the content to "This is my default action..."
Run the program, Confirm the changes applied in browser:
The URL to confirm
https://localhost:7129/HelloWorld

1415
Now i added another index welcome with the content "This is the Welcome action method..."
Run and Confirmed the changes works:
The URL to confirm
https://localhost:7129/HelloWorld/welcome

1420
Here I changed the Welcome method to include two parameters(name,numtimes)
Run the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/HelloWorld/Welcome/?name=Balu&numtimes=6

1430
Then replaced the Welcome method and changed the parameters(name,id)
Run the program and confirmed the changes works:
The URL to confirm
https://localhost:7129/HelloWorld/Welcome/66?name=Balu

2024/17/05

1020
starting part3
NoW, In the HelloWorldController class, I replaced the Index method and return a view
Then, added a new folder named HelloWorld under the Views folder.
Added  Razor View - Empty page called Index.cshtml under HelloWorld folder
Replaced the contents of the Views/HelloWorld/Index.cshtml
Then, confirmed the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/HelloWorld

1030
Here, I opened the Views/Shared/_Layout.cshtml file
then, replaced the MvcMovie1 to Movie App.
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/HelloWorld

1035
Then I checked the working Privacy link.Also confirmed how the title on the browser tab displays Privacy Policy - Movie App instead of Privacy Policy - MvcMovie
Compile the program and confirmed the changes works:
The URL to confirm
https://localhost:7129/Home/Privacy

1055
Here we have changed the title of the page from movieapp to Movie List in index.html and debug and confirmed all are working fine in Browser.
https://localhost:7129/HelloWorld

1100
This step I have to pass Data from the Controller to the View
Then change the Welcome method inside the HolloWorldController to add a Message and NumTimes value to the ViewData dictionary.
Then I create a Welcome view template named Views/HelloWorld/Welcome.cshtml.
Run the program, Confirmed the changes works ad data shows numtimes.
The URL to confirm
https://localhost:7129/HelloWorld/Welcome?name=Balu&numtimes=4


2024/23/05

1402
Starting part4
Here we are trying to add a data model class named Movie.cs

1615
Add New Scaffolded Item MVC Controller with views, using Entity Framework(v1.0.0.0).
Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.
Compiled the code and confirmed the pages and methods created(A movies controller:MoviesController.cs; View Pages: Create, Delete, Details, Edit, and Index; database context class: Data/MvcMovieContext.cs)


1620
Here, i tried to add Migrations feature to create the database.
Examine the generated database connection string in appsettings.json file
Examine the Migrations/20240530052824_InitialCreate.cs migration file:
Confirmed with table creation called Movie.
Compile the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/movies/
https://localhost:7129/Movies/Create
https://localhost:7129/Movies/Edit/6
https://localhost:7129/Movies/Delete/10
https://localhost:7129/Movies/Details/6

1635
Starting part5
Examine the database by opening SQL Server Object Explorer (SSOX).
Create a new class named SeedData in movie model
Replace the contents of Program.cs
Run the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/Movies



1500
Starting part6
add a blank space in Release data heading by editing Movie model class called Movie
Run the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/Movies


2024/26/05
Starting part7
1015
Adding search capability to the Index action method that lets to search movies by name.
Update the Index method found inside Controllers/MoviesController.cs
Run the program, Confirmed the changes works:
The URL to confirm
https://localhost:7129/Movies/Index?searchString=Ghost

1031
Change the search parameter to id and change all occurrences of searchString to id.
The updated Index method inside Controllers/MoviesController.cs with id parameter
https://localhost:7129/Movies/Index/Ghost

1101
Now I tried to add column filter UI elements to help filter movies.
I have added the <form> markup in the Views/Movies/Index.cshtml file
Run the program, Confirmed the changes works, Now i can see the filter box inside the browser.
The URL to confirm
https://localhost:7129/Movies

30052024

1330
Here I tried to add index search by adding the filter.
confirmed that the index is working fine. here while trying to search ghost in filter i am getting the movies name ghost only.
https://localhost:7129/Movies?SearchString=ghost

1400
Here I have added search by Genere
No we have added edited the index and edited the moviescontroller.cs string by adding the genre code.
https://localhost:7129/Movies?MovieGenre=Comedy&SearchString=

1420
Part 8
Here I have added the rating filter. Here 
https://localhost:7129/Movies


1425
Here we have added rating index, here i have encounted an issue with rating was not displaying and then i have added rating in seeddata.cs, Edit.cshtml,Details.cshtml, Delete.cshtml,Create.cshtml, index.cshtml etc
Now I can see the rating tab in all the options and i am able to add rating also inside the column.
The Migration raing timestamp can be noticed 20240530183300_Rating
Here i can see index page
https://localhost:7129/Movies
here i can see the edit rating tab
https://localhost:7129/Movies/Edit/6
In this page in display if i edit i can add arating inside the page also
https://localhost:7129/Movies/Edit/7

1510
Part 9
Here i have added advanced validation to the fields.
I tried to edit values for Title, Genre, Rating, Price
https://localhost:7129/Movies


