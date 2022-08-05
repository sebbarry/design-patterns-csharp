
/*
 *
 * this class is what allows us to loop through the iterators
 *
 */

namespace Patterns 
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu; 
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu) 
        {
            this.pancakeHouseMenu = pancakeHouseMenu; 
            this.dinerMenu = dinerMenu;
        }

        public void printMenu() 
        {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.Write("Menu: ------\n ------- \nBreakfast");
            printMenu(pancakeIterator); // method call 1
            Console.Write("\nLunch ----");
            printMenu(dinerIterator); // method call 2
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
                MenuItem menuItem = iterator.next();
                Console.Write(menuItem.getName() + " -- ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.Write(menuItem.getDescription() + " -- ");
            }
        }
    }
}
