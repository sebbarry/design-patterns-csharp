
/*
 *
 * this class is what allows us to loop through the iterators
 * it has no idea how the iterators hold the data. all it knows is that it
 * can iteratate over the lower level data structures in a seamless way.
 *
 */
using System.Collections;

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
            IEnumerator pancakeIterator   =    pancakeHouseMenu.createIterator();
            IEnumerator dinerMenuIterator =    dinerMenu.createIterator();

            Console.Write("Menu: ------\n ------- \nBreakfast");
            printMenu(pancakeIterator); // method call 1

            Console.Write("\nLunch ----");
            printMenu(dinerMenuIterator); // method call 2
        }

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
