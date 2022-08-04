using System.Collections;

namespace Patterns
{


    public class PancakeHouseMenu
    {

        List<MenuItem> menuItems;
        
        public PancakeHouseMenu() 
        {
            this.menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true,  2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs , sausage", false,  4.99);
            AddItem("Blueberry pancakes","Pancakes made with fresh blueberries.", true,  2.99);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries.", true,  2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public List<MenuItem> GetMenuItems() 
        {
            return menuItems;
        }


        // other methods here.

    }
}
