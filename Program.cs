using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class Restaurant
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public List<string> MenuItems { get; set; }
            public Restaurant(string name, string location)
            {
                Name = name;
                Location = location;
                MenuItems = new List<string>();
            }
            public void AddMenuItem(string item)
            {
                MenuItems.Add(item);
            }
            public void DisplayMenu()
            {
                Console.WriteLine($"Menu for {Name} in {Location}:");
                foreach (var item in MenuItems)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
    }
}
