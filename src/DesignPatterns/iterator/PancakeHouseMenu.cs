using System;
using System.Collections;

namespace Patterns
{
    public class PancakeHouseMenu : Menu
    {

        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        ArrayList menuItems;

        public PancakeHouseMenu()
        {

            this.menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regualar Pancake Breakfast", "Pancakes with scrambled eggs and toas.", false, 2.99);
            AddItem("Pancakes made with fresh blueberries", "Waffles description", true, 4.99);
            AddItem("Blueberry Pancakes.", "Pancakes with fresh blueberries", true, 5.99);

        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {

            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            if ( numberOfItems >= MAX_ITEMS )
            {
                Console.Write("menu is full");
            }
            else
            {
                //menuItems[numberOfItems] = menuItem;
                menuItems.Add(menuItem);
                numberOfItems++;
            }

        }

        public ArrayList getMenuItems()
        {
            return menuItems;
        }

        public IEnumerator createIterator()
        {
            IEnumerator ie = menuItems.GetEnumerator();
            return ie;
        }
    }
}
