using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration and initialization of strings
            string string1 = "Esta é uma string normal onde \u03c0 é unicode com escape.";
            string string2 = @"Esta é uma string verbatim onde \u03c0 é unicode com escape.";
            string string3 = "styring normal com barra \\";
            string string4 = @"styring verbatim com barra \";
            string string5 = "\"aspas em string normal\"";
            string string6 = @"""aspas em string verbatim""";

            //string prints
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(string4);
            Console.WriteLine(string5);
            Console.WriteLine(string6);
        }
    }
}
