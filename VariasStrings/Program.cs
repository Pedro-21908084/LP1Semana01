using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration and initialization of strings
            string string1 = "Esta é uma string normal onde \u03c0 é unicode" + 
            " com escape.";
            string string2 = @"Esta é uma string verbatim onde \u03c0 é " + 
            "unicode com escape.";
            string string3 = "styring normal com barra \\";
            string string4 = @"styring verbatim com barra \";
            string string5 = "\"aspas em string normal\"";
            string string6 = @"""aspas em string verbatim""";

            // extra variables for exercise 5
            int x = 5;
            int y = 3;
            //declaration and initialization of strings for exercise 5
            string string7 = "x = " + x;
            string string8 = "number = " + 5;
            string string9 = $"y = {y}";
            string string10 = $"{x} + {y} = {x + y}";
            string string11 = String.Format("x = {0} in string format", x);

            //string prints
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(string4);
            Console.WriteLine(string5);
            Console.WriteLine(string6);
            Console.WriteLine(string7);
            Console.WriteLine(string8);
            Console.WriteLine(string9);
            Console.WriteLine(string10);
            Console.WriteLine(string11);

            //declaration and initialization of the variables for exercise 6
            double xx = 0.12345;
            int ii = 18;

            Console.WriteLine($"xx in decimals: {xx:f2}, xx in percentage" + 
            " {xx:p1}");
            Console.WriteLine($"ii in hexa: 0x{ii:x}, ii in coin: {ii:c}");
        }
    }
}
