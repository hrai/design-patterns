namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class TomatoSauce : ISauce
    {
        public string Name() { return this.GetType().FullName; }
    }
}