namespace DesignPatterns.Factory.AbstractIngredientFactory.Ingredients
{
    public class BbqSauce : ISauce
    {
        public string Name() { return this.GetType().FullName; }
    }
}