using System;

namespace movietheater {
    class Program {
        static void Main(string[] args) {
            Theater Majestic = new Theater("Majestic");
            Menu menu = new Menu();
            PopulateMovies(Majestic);
            PopulateFood(Majestic);

			menu.ShowMenu(Majestic);
        }

        static void PopulateMovies(Theater theater) {
            //Make Movies
            Movie IT = new Movie("IT", "Clowns are Scary");
            Movie WeddingSinger = new Movie("The Wedding Singer", "Adam Sandler hahaha!");
            Movie JurassicPark = new Movie("Jurassic Park", "Dinosaurs Are Awesome!");

            //Made Showtimes
            IT.addShowtime("10:00", 5.99f, 100);
            IT.addShowtime("12:00", 5.99f, 100);
            IT.addShowtime("2:00", 5.99f, 100);

            WeddingSinger.addShowtime("10:00", 5.99f, 100);
            WeddingSinger.addShowtime("12:00", 5.99f, 100);
            WeddingSinger.addShowtime("2:00", 5.99f, 100);

            JurassicPark.addShowtime("10:00", 5.99f, 100);
            JurassicPark.addShowtime("12:00", 5.99f, 100);
            JurassicPark.addShowtime("2:00", 5.99f, 100);

            theater.addMovie(IT);
            theater.addMovie(WeddingSinger);
            theater.addMovie(JurassicPark);
        }

        static void PopulateFood(Theater theater) {
            //Make Food
            Food Nachos = new Food("Nachos", 5.99f, 25);
            Food Popcorn = new Food("Popcorn", 8.50f, 120);
            Food Drink = new Food("Drink", 4.99f, 200);

            //Add all items to Theater
            theater.addFood(Nachos);
            theater.addFood(Popcorn);
            theater.addFood(Drink);
        }
    }
}
