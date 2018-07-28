using DesignPatterns.Factory.AbstractIngredientFactory.Ingredients;

namespace DesignPatterns.Factory.AbstractIngredientFactory
{
    public class SydIngredientFactory : IIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinDough();
        }

        public ISauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public IMeat CreateMeat()
        {
            return new ChickenMeat();
        }

        public IVeggie CreateVeggie()
        {
            return new Olive();
        }
    }
}