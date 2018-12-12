using System;
using System.Collections.Generic;

namespace Iterator
{
    public class DinnerMenu
    {
        private Dish[] menuItems;

        public DinnerMenu()
        {
            Console.WriteLine("Creating dinner menu...");
            menuItems = new Dish[10];

            CreateMenuItem(0, "Fish curry");
            CreateMenuItem(1, "Hotpot");

            Console.WriteLine("Dinner menu created...");
        }

        public void CreateMenuItem(int pos, string name) {
            menuItems[pos] = new Dish(name);
        }

        public IEnumerator<Dish> CreateIterator()
        {
            return new DinnerEnumerator(menuItems);
        }
    }
}
