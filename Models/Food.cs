namespace movietheater {
    public class Food : IPurchasable {
        public string Name;
        public float Cost { get; set; }
        public int Inventory { get; set; }

        public string MenuDescription { get { return Name; } }

        public bool Purchase(int quantity) {
            if (Inventory - quantity >= 0) {
                Inventory -= quantity;
                System.Console.WriteLine($"Here is your {quantity}, {Name}");
                return true;
            }
            System.Console.WriteLine($"Sorry, but we have { (Inventory == 0 ? "none" : Inventory.ToString())} left");
            return false;
        }
        public Food(string name, float cost, int inventory) {
            Name = name;
            Cost = cost;
            Inventory = inventory;
        }
    }
}