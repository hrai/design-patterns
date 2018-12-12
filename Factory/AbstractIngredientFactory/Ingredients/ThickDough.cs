namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class ThickDough : IDough
    {
        public string Name() { return this.GetType().FullName; }
    }
}