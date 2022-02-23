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


            //printing of the variables
            Console.WriteLine(string.Format("Inteiro: {0} \nInteiro sem sinal: {1}\nCharacter: {2}\nCharacter: {3}\nCharacter: {4}", inteiro1, inteiro2, character1, character2, character3));
        }
    }
}
