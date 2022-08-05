using System.Collections;

namespace Patterns 
{
    public class DinerMenu 
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
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS) 
            {
                Console.Write("menu is full!");
            } 
            else 
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator createIterator() 
        {
            // create a new diner menu iterator w/ parent classes diner menu items.
            return new DinerMenuIterator(menuItems);
        }


        // other dinermenu methods here.
    }
}
