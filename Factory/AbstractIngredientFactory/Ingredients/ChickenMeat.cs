namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class ChickenMeat : IMeat
    {
        public string Name() { return this.GetType().FullName; }
    }
}