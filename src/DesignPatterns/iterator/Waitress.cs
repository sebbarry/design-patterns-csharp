
/*
 *
 * this class is what allows us to loop through the iterators
 * it has no idea how the iterators hold the data. all it knows is that it
 * can iteratate over the lower level data structures in a seamless way.
 *
 */
using System.Collections.Generic;

namespace Patterns
{
    public class Waitress
    {
        // Menu iterfaces that we can adhere to.
        Menu pancakeHouseMenu;
        Menu dinerMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            IEnumerate<MenuItem> pancakeIterator = pancakeHouseMenu.createIterator();
            IEnumerate<MenuItem> dinerMenuIterator = dinerMenu.createIterator();

            Console.Write("Menu: ------\n ------- \nBreakfast");
            printMenu(pancakeIterator); // method call 1
            Console.Write("\nLunch ----");
            printMenu(dinerMenuIterator); // method call 2
        }

        /*
         *
         * Here we implement the second printeMenu method that allows us to loop through each item in the iterator.
         *
         */
        public void printMenu(Iterator iterator)
        {
            while(iterator.hasNext())
            {
                // retrieve the menu item from the iterator.
                MenuItem menuItem = iterator.next();
                Console.Write(menuItem.getName() + " -- ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.Write(menuItem.getDescription() + " -- ");
            }
        }
    }
}
