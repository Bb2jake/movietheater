namespace movietheater {
    public class Ticket : IPurchasable {
        Movie Movie;
        string Time;
        public float Cost { get; set; }
        public int Inventory { get; set; }
        public string MenuDescription { get { return Time; } }

        public bool Purchase(int quantity) {
            if (Inventory - quantity >= 0) {
                Inventory -= quantity;
                System.Console.WriteLine($"Here is your ticket(s)");
                return true;
            }
            System.Console.WriteLine($"Sorry, but we have { (Inventory == 0 ? "none" : Inventory.ToString())} left");
            return false;
        }
        public Ticket(Movie movie, string time, float cost, int inventory) {
            Movie = movie;
            Time = time;
            Cost = cost;
            Inventory = inventory;
        }
    }
}