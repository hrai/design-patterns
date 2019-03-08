using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public interface IMealBuilder
    {
        IMealBuilder BuildEntree(string entree);
        IMealBuilder BuildMains(string mains);
        IMealBuilder BuildDessert(string dessert);
        IMealBuilder BuildDrinks(string drinks);
        IMeal GetMeal();
    }
}
