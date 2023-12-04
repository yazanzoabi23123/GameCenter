using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{
    internal class MovieLibrary : Movie
    {
        public List<Movie> movies { get; set; }

        public MovieLibrary()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie added successfully!");
        }

        public void EditMovie(int id)
        {
            var movieToEdit = movies.Find(movie => movie.id == id);
            if (movieToEdit != null)
            {
                Console.WriteLine("Enter new title:");
                movieToEdit.title = Console.ReadLine();
                Console.WriteLine("Enter new director:");
                movieToEdit.director = Console.ReadLine();
                Console.WriteLine("Enter new release year:");
                movieToEdit.releaseYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Movie edited successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found!");
            }
        }

        public void DeleteMovieById(int id)
        {
            var movieToDelete = movies.Find(movie => movie.id == id);
            if (movieToDelete != null)
            {
                movies.Remove(movieToDelete);
                Console.WriteLine("Movie deleted successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found!");
            }
        }

        public void DeleteMoviesByTitleStartingWith(string letter)
        {
            movies.RemoveAll(movie => movie.title.StartsWith(letter, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Movies starting with '{letter}' deleted successfully!");
        }
    }
}
