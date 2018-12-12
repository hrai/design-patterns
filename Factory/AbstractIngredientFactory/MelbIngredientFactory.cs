using DesignPatterns.Factory.AbstractIngredientFactory.Ingredients;

namespace DesignPatterns.Factory.AbstractIngredientFactory
{
    public class MelbIngredientFactory : IIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickDough();
        }

        public ISauce CreateSauce()
        {
            return new BbqSauce();
        }

        public IMeat CreateMeat()
        {
            return new PorkMeat();
        }

        public IVeggie CreateVeggie()
        {
            return new Capsicum();
        }
    }
}