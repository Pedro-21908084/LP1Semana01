using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of varianles needed
            string userString;

            //Get user string
            Console.WriteLine("Hello, Please give me a string:");
            userString = Console.ReadLine();

            //invert string in print
            for (int i = 0; i < userString.Length; i++)
            {
                Console.Write(userString[userString.Length - i - 1]);
            }
            //print end of line
            Console.Write("\n");
        }
    }
}
