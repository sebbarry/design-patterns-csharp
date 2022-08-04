/*
This pattern: 
- allows us to iterate over a collection in O(n) speed.
- allows us to aggregate collections into a single data structure
and iterate over it in a single method.
 */


namespace Patterns
{
    public class IteratorPattern
    {
        public void Run() 
        {
            Console.Write("hello world");
            MenuItem mI = new MenuItem("name", "this is de", true, 4.4);
            Console.Write(mI.getName());
        }
    }
}
