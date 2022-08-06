/*

 not in use.
 replaced w/ IEnumerator (this is a C# sharp thing) .

*/

namespace Patterns
{
    // make the iterator class here adhere to the iterator interface.
    public class DinerMenuIterator : Iterator
    {

        // store menu items here.
        MenuItem[] items;
        // keep track of the position of the iterator.
        int position = 0;

        // constructor.
        public DinerMenuIterator( MenuItem[] items )
        {
            this.items = items;
        }

        // next method
        public MenuItem next()
        {
            MenuItem item = items[position];
            position++; // increment the position of the class as we iterate
            return item;
        }

        // method to handle error checking.
        public bool hasNext()
        {
            if ( position >= items.Length || items[position] == null )
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
