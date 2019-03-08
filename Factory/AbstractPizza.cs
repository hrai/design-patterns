using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public abstract class AbstractPizza
    {
        public IIngredientFactory IngredientFactory;
        public string Name;

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
