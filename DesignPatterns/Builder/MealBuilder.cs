using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class MealBuilder : IMealBuilder
    {
        private Meal meal;

        public MealBuilder(){
            meal = new Meal();
        }

        public IMealBuilder BuildDessert(string dessert)
        {
            meal.Dessert = dessert;
            return this;
        }

        public IMealBuilder BuildDrinks(string drinks)
        {
           meal. Drinks = drinks;
            return this;
        }

        public IMealBuilder BuildEntree(string entree)
        {
            meal.Entree = entree;
            return this;
        }

        public IMealBuilder BuildMains(string mains)
        {
            meal.Mains = mains;
            return this;
        }

        public IMeal GetMeal()
        {
            return meal;
        }
    }
}