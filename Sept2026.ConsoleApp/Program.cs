using Sept2026.ConsoleApp;
using System.Diagnostics;

Console.WriteLine("Movie Management System");

Start:
Console.Write("Please enter movie title: ");
string title = Console.ReadLine();

GenreStart:
Console.WriteLine("Please enter genre: ");
Console.WriteLine("1. Sci-Fi");
Console.WriteLine("2. Drama");
Console.WriteLine("3. Romance");
Console.WriteLine("4. Horror");
Console.WriteLine("Please select a option (1 or 2 or 3 or 4): ");

string option = Console.ReadLine();
string genre;

switch (option)
{
    case "1": genre = "Sci-Fi"; break;
    case "2": genre = "Drama"; break;
    case "3": genre = "Romance"; break;
    case "4": genre = "Horror"; break;
    default:
        Console.WriteLine("Invalid genre option!");
        goto GenreStart;
}

Console.Write("Please enter release year: ");
int releaseYear = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter duration: ");
int duration = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter director: ");
string director = Console.ReadLine();

Console.Write("Please enter rating: ");
string rating = Console.ReadLine();

MovieService movieService = new MovieService();
movieService.CreateMovie(title, genre, releaseYear, duration, director, rating);

movieService.ShowMovies();

MovieMenu:
Console.WriteLine("Do you wanna create another movie?");
Console.WriteLine("Please select a option (yes or no): ");

string option2 = Console.ReadLine();

switch(option2)
{
    case "yes": goto Start; break;
    case "no": goto End; break;
    default:
        Console.WriteLine("Invalid option!");
        goto MovieMenu;
}
Console.ReadLine();
End:
Console.WriteLine("Exiting App.....");