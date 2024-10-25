  
using System;
using System.Collections.Generic;

namespace DataTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Asosiy ma'lumot turlari
            int a = 5;               // Butun son
            double b = 5.5;         // O'nli son
            float c = 5.5f;         // Float o'nli son
            decimal d = 5.5m;       // Decimal o'nli son
            char e = 'A';           // Belgilar
            string f = "Hello";     // Belgilar qatori
            bool g = true;          // Mantiqiy qiymat

            // 2. Qo'shimcha ma'lumot turlari
            long h = 1234567890123; // Katta butun son
            short i = 32000;        // Kichik butun son
            byte j = 255;           // Byte
            sbyte k = -128;        // Sbyte
            uint l = 12345;         // Musbat butun son
            ulong m = 1234567890123456789; // Katta musbat butun son
            ushort n = 65535;       // Musbat kichik butun son

            // 3. Nullable ma'lumot turlari
            int? p = null;          // Nullable integer

            // 4. Obyektga oid turlar
            object q = "Hello";     // Har qanday turdagi qiymat

            // 5. Kolleksiya turlari
            int[] arr = { 1, 2, 3 }; // Array
            List<int> list = new List<int> { 1, 2, 3 }; // List

            // Natijalarni chiqarish
            Console.WriteLine("int: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("float: " + c);
            Console.WriteLine("decimal: " + d);
            Console.WriteLine("char: " + e);
            Console.WriteLine("string: " + f);
            Console.WriteLine("bool: " + g);
            Console.WriteLine("long: " + h);
            Console.WriteLine("short: " + i);
            Console.WriteLine("byte: " + j);
            Console.WriteLine("sbyte: " + k);
            Console.WriteLine("uint: " + l);
            Console.WriteLine("ulong: " + m);
            Console.WriteLine("ushort: " + n);
            Console.WriteLine("nullable int: " + p);
            Console.WriteLine("object: " + q);
            Console.WriteLine("array: " + string.Join(", ", arr));
            Console.WriteLine("list: " + string.Join(", ", list));
        }
    }
}
