using Lab4.Models;

namespace Lab4.Models
{
    public class Application
    {
        public OS SupportedOS;
        public bool Paid;
        public string Name;
        public double Price;
        public double Version;
        public string Author;

        public Application(OS OS,
            bool Paid,
            string Name,
            double Price,
            double Version,
            string Author)
        {
            this.SupportedOS = OS;
            this.Paid = Paid;
            this.Name = Name;
            this.Price = Price;
            this.Version = Version;
            this.Author = Author;
        }
    }
}