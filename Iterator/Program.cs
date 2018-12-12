using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinnerMenu = new DinnerMenu();
            var lunchMenu = new LunchMenu();

            var menuIterators = new List<IEnumerator<Dish>>();
            menuIterators.Add(dinnerMenu.CreateIterator());
            menuIterators.Add(lunchMenu.CreateIterator());

            var waitress = new Waitress(menuIterators);
            waitress.printMenuItems();
        }
    }
}
