namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class ThinDough : IDough
    {
        public string Name() { return this.GetType().FullName; }
    }
}