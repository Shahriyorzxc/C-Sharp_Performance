// For
using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello World! " + i);
            }
        }
    }
}





// While
using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Hello World! " + i);
                i++;
            }
        }
    }
}


// Foreach

using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { "Hello", "Hi", "Greetings", "Welcome" };

            foreach (string greeting in greetings)
            {
                Console.WriteLine(greeting);
            }
        }
    }
}
// DoWhile
using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Hello World! " + i);
                i++;
            } while (i < 5);
        }
    }
}
