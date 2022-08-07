
/*
 *
 * this class is what allows us to loop through the iterators
 * it has no idea how the iterators hold the data. all it knows is that it
 * can iteratate over the lower level data structures in a seamless way.
 *
 */
using System;

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
            System.Collections.IEnumerator pancakeIterator   =    pancakeHouseMenu.createIterator();
            System.Collections.IEnumerator dinerMenuIterator =    dinerMenu.createIterator();

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
        public static void printMenu(System.Collections.IEnumerator iterator)
        {

            while(iterator.MoveNext() && iterator.Current != null)
            {
                // retrieve the menu item from the iterator.
                MenuItem menuItem = (MenuItem) iterator.Current;
                Console.Write(menuItem.getName() + " -- ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.Write(menuItem.getDescription() + " -- ");
            }

        }

    }
}
