# MoviesWebApp

This is a web application that allows users to browse, filter, and manage a collection of movies. The application uses a SQL Server database to store and retrieve movie data. Users can view, create, edit, and delete movie entries.
<https://www.thecsharpacademy.com/project/25/movies>

## Features

- Contains models for movies and a context to manage the movie data.
- Uses Entity Framework Core to interact with the database and create the necessary schema.
- Displays a list of movies with options to filter by title, genre, and rating.
- Allows users to sort movies by title, release date, price, genre, and rating.
- Provides a user-friendly interface for managing movie entries.

## Getting Started

To run the application, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Run `Update-Database` in the package manager console to create the SQL database.
4. Build the solution to restore NuGet packages and compile the code.
5. Run the `MoviesWebApp` project to start the web application.

## Dependencies

- Microsoft.EntityFrameworkCore: The application uses this package to manage the database context and entity relationships.
- Microsoft.AspNetCore.Mvc.RazorPages: The application uses this package to create Razor Pages for the web interface.

## Usage

1. The application will display a list of movies with options to filter and sort the entries.
2. Use the search box and dropdown menus to filter movies by title, genre, and rating.
3. Click on the column headers to sort the movies by the selected attribute.
4. Use the links provided to create, edit, view details, or delete movie entries.

## License

This project is licensed under the MIT License.

## Resources Used

- [The C# Academy](https://www.thecsharpacademy.com/)
- [Razor Pages tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-8.0)
- [Entity Framework Core Docs](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/)
- GitHub Copilot to generate code snippets.
