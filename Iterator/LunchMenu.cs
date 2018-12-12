using System;
using System.Collections.Generic;

namespace Iterator
{
    public class LunchMenu
    {
        private IList<Dish> menuItems;

        public LunchMenu()
        {
            Console.WriteLine("Creating lunch menu...");
            menuItems = new List<Dish>();

            CreateMenuItem(0, "Momo");
            CreateMenuItem(1, "Pad thai");

            Console.WriteLine("Lunch menu created...");
        }

        public void CreateMenuItem(int pos, string name) {
            menuItems.Add(new Dish(name));
        }

        public IEnumerator<Dish> CreateIterator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
