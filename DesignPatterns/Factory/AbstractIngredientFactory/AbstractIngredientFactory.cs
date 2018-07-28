using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.AbstractIngredientFactory
{
    public interface IIngredientFactory
    {
       IDough CreateDough();
       ISauce CreateSauce();
       IMeat CreateMeat();
       IVeggie CreateVeggie();
    }

    public interface IVeggie
    {
        string Name();
    }

    public interface IMeat
    {
        string Name();
    }

    public interface ISauce
    {
        string Name();
    }

    public interface IDough
    {
        string Name();
    }
}
