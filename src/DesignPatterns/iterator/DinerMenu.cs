using System.Collections;

namespace Patterns
{
    public class DinerMenu : Menu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            this.menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT", "Bacon with lettuce and tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce and tomato on whole wheat", false, 2.99);
            AddItem("Soup of the Day", "Soup of the day right here!", true, 5.99);
            AddItem("HotDog", "hot dog for our lovely people.", true, 6.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            // make a new item
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            // check if we are exceeding the amount of items available to us
            // on the menu.
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.Write("menu is full!");
            }
            else
            {
                // add teh menuitem to the array.
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        // return a new iterator.
        public IEnumerator<MenuItem> createIterator()
        {
            // create a new diner menu iterator w/ parent classes diner menu items.
            IEnumerator<MenuItem> ie = menuItems.GetEnumerator();
            return ie; //menuItems.iterator(); //DinerMenuIterator(menuItems); //menuItems.iterator();//
        }


        // other dinermenu methods here.


    }
}
