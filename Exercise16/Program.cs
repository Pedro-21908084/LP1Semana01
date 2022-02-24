using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string userNumber1;
            string userNumber2;
            string userResult;
            int number1;
            int number2;
            int result;

            Console.WriteLine("Hello, in this program ill tell you if two numbers given result in the third.");

            //Read user input
            Console.Write("Tell me the first integer number: ");
            userNumber1 = Console.ReadLine();
            Console.Write("Now the second number: ");
            userNumber2 = Console.ReadLine();
            Console.Write("And finally, tell me the result of their addition: ");
            userResult = Console.ReadLine();

            //Convert to int
            number1 = Convert.ToInt32(userNumber1);
            number2 = Convert.ToInt32(userNumber2);
            result = Convert.ToInt32(userResult);

            //Check and print results
            if (number1 + number2 == result)
            {
                Console.WriteLine("Is possible :)");
            }
            else
            {
                Console.WriteLine("Impossible :(");
            }
        }
    }
}
