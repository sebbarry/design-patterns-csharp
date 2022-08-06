using System.Collections;

namespace Patterns
{
    // interface for a common menu-type class.
    public interface Menu
   {
       public IEnumerator<MenuItem> createIterator();
   }
}
