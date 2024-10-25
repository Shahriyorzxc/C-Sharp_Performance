using System;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("Son musbat.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Son manfiy.");
            }
            else
            {
                Console.WriteLine("Son nolga teng.");
            }
        }
    }
}