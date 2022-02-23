using System;
using System.Text;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //declaration and initialization of ints
            int inteiro1 = -12;
            uint inteiro2 = 20U;

            //declaration and initialization of chars
            char character1 = '\u1f9a';
            char character2 = '\u1f60';
            char character3 = '\u03c0';

            //declaration and initialization of real numbers
            float real1 = 3.1415f;
            double real2 = 1.34;


            //printing of the variables
            Console.WriteLine(string.Format("Inteiro: {0} \nInteiro sem sinal: {1}", inteiro1, inteiro2));
            Console.WriteLine(string.Format("Character: {0}\nCharacter: {1}\nCharacter: {2}", character1, character2, character3));
            Console.WriteLine(string.Format("Real: {0}\nReal: {1}", real1, real2));
        }
    }
}
