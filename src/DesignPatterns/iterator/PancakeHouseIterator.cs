/*

 not in use.
 replaced w/ IEnumerator (this is a C# sharp thing) .

*/


namespace Patterns
{
    public class PancakeHouseIterator : Iterator
    {

        MenuItem[] menuItems;
        int position = 0;

        public PancakeHouseIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public MenuItem next()
        {
            // get the menu item at position n
            MenuItem menuItem = menuItems[position];
            // increase the position of the list
            position++;
            // return the menuItem
            return menuItem;
        }

        public bool hasNext()
        {
            if( position >= menuItems.Length || menuItems[position] == null )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
