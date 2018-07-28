namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class Olive : IVeggie
    {
        public string Name() { return this.GetType().FullName; }
    }
}