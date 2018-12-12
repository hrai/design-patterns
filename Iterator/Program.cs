using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinnerMenu = new DinnerMenu();
            var iterator = dinnerMenu.CreateIterator();
            printMenuItems(iterator);
        }

        private static void printMenuItems(IIterator iterator)
        {
            while(iterator.hasNext())
            {
                Console.WriteLine(iterator.next().Name);
            }
        }
    }
}
