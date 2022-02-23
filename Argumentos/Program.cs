using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //cycles every argument given in args
            for (int i = 0; i < args.Length; i++)
            {
                //prints the argument in args[i]
                Console.WriteLine(args[i]);
            }
        }
    }
}

