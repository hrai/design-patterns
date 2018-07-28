namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class Capsicum : IVeggie
    {
        public string Name() { return this.GetType().FullName; }
    }
}