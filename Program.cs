
using Patterns;

namespace Program 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            // start here.
            callIteratorPattern();
        }
        public static void callIteratorPattern() 
        {
            IteratorPattern iterator = new IteratorPattern();
            iterator.Run();
        }
    }
}
