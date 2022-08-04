namespace Patterns 
{
    public class DinerMenuIterator : Iterator 
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items) 
        {
            this.items = items;
        }

        public MenuItem next() 
        {
            MenuItem item = items[position];
            position++;
            return item;
        }

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
