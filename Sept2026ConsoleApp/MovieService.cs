using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept2026.ConsoleApp
{
    public class MovieService
    {
        public static List<MovieDto> Movies = new List<MovieDto>();
        public void CreateMovie(string Title, string Genre, int ReleaseYear, int Duration, string Director, string Rating)
        {
            int maxId = Movies.Count == 0 ? 0 : Movies.Max(x => x.MovieId);
            MovieDto movie = new MovieDto
            {
                MovieId = maxId + 1,
                Title = Title,
                Genre = Genre,
                ReleaseYear = ReleaseYear,
                Duration = Duration,
                Director = Director,
                Rating = Rating
            };
            Movies.Add(movie);

            Console.WriteLine("Successfully Movie Added!");
        }

        public void ShowMovies()
        {
            Console.WriteLine("-----Movie List-----");
            foreach (var item in Movies)
            {
                Console.WriteLine($"Id: {item.MovieId} | Genre: {item.Genre}  | Title: {item.Title} | ReleaseYear: {item.ReleaseYear}" +
                    $" | Duration: {item.Duration} | Director: {item.Director} | Rating: {item.Rating}");
            }
        }
    }
}
