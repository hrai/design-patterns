using System;

namespace DesignPatterns.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var mealBuilder = new MealBuilder()
               .BuildEntree("spring rolls")
               .BuildMains("pad thai")
               .BuildDrinks("coke")
               .BuildDessert("mousse");

           var meal = mealBuilder.GetMeal();

           Console.WriteLine("Running builder pattern code...");
           Console.WriteLine(((Meal)meal).Entree);
           Console.WriteLine(((Meal)meal).Mains);
           Console.WriteLine(((Meal)meal).Dessert);
        }
    }
}
