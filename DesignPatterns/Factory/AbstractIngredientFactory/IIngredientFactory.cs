namespace DesignPatterns.Factory.AbstractIngredientFactory
{
    public interface IIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        IMeat CreateMeat();
        IVeggie CreateVeggie();
    }
}