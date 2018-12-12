using System;

namespace Iterator
{
    public class DinnerMenu
    {
        private Dish[] menuItems;

        public DinnerMenu()
        {
            Console.WriteLine("Creating dinner menu");
            menuItems = new Dish[10];

            CreateMenuItem(0, "Fish curry");
            CreateMenuItem(1, "Hotpot");
        }

        public void CreateMenuItem(int pos, string name) {
            menuItems[pos] = new Dish(name);
        }

        public IIterator CreateIterator()
        {
            return new DinnerIterator(menuItems);
        }
    }
}
