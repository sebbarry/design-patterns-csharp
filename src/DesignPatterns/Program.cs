
using Patterns;


namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // start here.
            CallIteratorPattern();
        }
        public static void CallIteratorPattern()
        {
            IteratorPattern iterator = new IteratorPattern();
            iterator.Run();
        }
    }
}
