using System.Collections.Generic;

namespace movietheater {
    public class Movie : IMenuItem {
        public string Title;
        public string Description;
        public string MenuDescription { get { return Title; } }
        public List<Ticket> Showtimes = new List<Ticket>();

        public void addShowtime(string time, float cost, int inventory) {
            Showtimes.Add(new Ticket(this, time, cost, inventory));
        }
        public Movie(string title, string description) {
            Title = title;
            Description = description;
        }
    }
}