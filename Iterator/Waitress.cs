using System;
using System.Collections.Generic;

namespace Iterator
{
    internal class Waitress
    {
        private IList<IEnumerator<Dish>> menuIterators;

        public Waitress(List<IEnumerator<Dish>> menuIterators)
        {
            this.menuIterators = menuIterators;
        }

        public void printMenuItems()
        {
            foreach(var menuIterator in menuIterators)
            {
                System.Console.WriteLine("Printing menu items...");

                while(menuIterator.MoveNext())
                {
                    var currentItem = menuIterator.Current;
                    Console.WriteLine($"# {menuIterator.GetType().Name} : {currentItem.Name}");
                }
            }
        }
    }
}
