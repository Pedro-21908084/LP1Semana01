using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            
            Console.WriteLine("Hello, Please give me a string:");
            userString =  Console.ReadLine();
            Console.WriteLine("Did you write:");
            Console.WriteLine(userString + " ?");
        }
    }
}
