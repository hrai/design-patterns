namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class PorkMeat : IMeat
    {
        public string Name() { return this.GetType().FullName; }
    }
}