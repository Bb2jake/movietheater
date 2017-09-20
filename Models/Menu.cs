using System;
using System.Linq;
using System.Collections.Generic;

namespace movietheater {
    class Menu {
        Theater theater;
        Movie movie;

        public void ShowMenu(Theater theater) {
            this.theater = theater;
            Console.Clear();
            Console.WriteLine($"Welcome to the {theater.Name} theater!");
            ShowMovies();
        }

        void ShowMovies() {
            for (var i = 0; i < theater.Movies.Count; i++) {
                Show(theater.Movies[i], i);
            }

            Console.WriteLine("Please select a movie to watch!");
            int num;
            var input = Console.ReadLine();
            if (int.TryParse(input, out num) && num > 0 && num <= theater.Movies.Count) {
                movie = theater.Movies[num - 1];
                Console.Clear();
                ShowMovieTimes();
            } else {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                ShowMovies();
            }
        }

        void ShowMovieTimes() {
            Console.WriteLine($"Movie: {movie.Title} Description: {movie.Description}");
            for (var i = 0; i < movie.Showtimes.Count; i++) {
                Show(movie.Showtimes[i], i);
            }
            Console.WriteLine("Please select a show time.");
            int num;
            var input = Console.ReadLine();
            if (int.TryParse(input, out num) && num > 0 && num <= movie.Showtimes.Count) {
				var ticket = movie.Showtimes[num - 1];
                Console.WriteLine($"{ticket.MenuDescription} showing selected.");
                ShowFood();
            } else {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                ShowMovies();
            }
        }

        void ShowFood() {
            for (var i = 0; i < theater.Menu.Count; i++) {
                Show(theater.Menu[i], i);
            }
            Console.WriteLine("Select some food to have while you watch the movie!");
            int num;
            var input = Console.ReadLine();
            if (int.TryParse(input, out num) && num > 0 && num <= theater.Menu.Count) {
                Console.WriteLine($"{theater.Menu[num - 1].Name} purchased. Enjoy your movie!");
				Environment.Exit(0);
            } else {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                ShowMovies();
            }
        }

        void Show(IMenuItem item, int index) {
            Console.WriteLine($"{(index + 1)}. {item.MenuDescription}");
        }
    }
}