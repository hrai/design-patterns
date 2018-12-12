
namespace Iterator
{
public class DinnerIterator:IIterator
{
    private Dish[] menuItems;
    private int position;

    public DinnerIterator(Dish[] menuItems)
    {
        this.menuItems = menuItems;
        position=0;
    }

    public bool hasNext() 
    {
        if(position < menuItems.Length && menuItems[position] != null)
        {
            return true;
        }
        
        return false;
    }

    public Dish next() 
    {
        return menuItems[position++];
    }
}
}