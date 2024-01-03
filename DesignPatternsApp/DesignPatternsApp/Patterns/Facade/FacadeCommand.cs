using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Facade
{
    public class FacadeCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Facade");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Facade é usado para fornecer uma interface simplificada para um conjunto de interfaces em um subsistema mais amplo, tornando mais fácil de usar.");
            Console.WriteLine("Contexto: Filme em casa.");
            Console.WriteLine();

            Amplifier amplifier = new Amplifier();
            DvdPlayer dvdPlayer = new DvdPlayer();
            Projector projector = new Projector();
            Lights lights = new Lights();

            // Cria a fachada
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, lights);

            Console.WriteLine("Escolha uma das opções de filmes abaixo para assistir:");

            var movies = GetMovies();
            foreach (var movie in movies)
                Console.WriteLine($"[{movie.Key}] - {movie.Value}");
            
            var movieId = Console.ReadLine();

            movies.TryGetValue(movieId, out var selectedMovie);

            if(selectedMovie == null)
                Console.WriteLine("Filme não encontrado!");
            else
            {
                homeTheater.WatchMovie(selectedMovie);
                homeTheater.EndMovie();
            }
            
            Console.WriteLine();
        }

        private Dictionary<string, string> GetMovies()
        {
            var movies = new Dictionary<string, string>();
            movies.Add("1","Guerra nas estrelas");
            movies.Add("2", "Interstellar");
            movies.Add("3", "Chernobyl");
            return movies;
        }
    }
}
