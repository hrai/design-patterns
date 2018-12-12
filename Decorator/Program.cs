using System;

namespace DesignPatterns.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var espresso = new Espresso();
           var mocha = new Mocha(espresso);
           var whip = new Whip(mocha);

           System.Console.WriteLine("Running decorator pattern code...");
           Console.WriteLine(mocha.Desc + " " + mocha.GetCost());
           Console.WriteLine(whip.Desc + " " + whip.GetCost());

           Console.ReadKey();
        }
    }
}
