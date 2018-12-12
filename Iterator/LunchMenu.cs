using System;

namespace Iterator
{
    public class LunchMenu
    {
        private ArrayList<Dish> menuItems;

        public LunchMenu()
        {
            Console.WriteLine("Creating lunch menu");
            menuItems = new ArrayList<Dish>();

            CreateMenuItem(0, "Fish curry");
            CreateMenuItem(1, "Hotpot");
        }

        public void CreateMenuItem(int pos, string name) {
            menuItems.Add(new Dish(name));
        }

        public IIterator CreateIterator()
        {
            return menuItems.iterator();
        }
    }
}
