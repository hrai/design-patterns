namespace DesignPatterns.Factory
{
    public abstract class AbstractPizza
    {
        public string Name;

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
