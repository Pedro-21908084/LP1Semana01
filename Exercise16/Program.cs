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
            string userNumber3;
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Hello, in this program ill tell you if two " + 
            "numbers given result in the third.");

            //Read user input
            Console.Write("Tell me the first integer number: ");
            userNumber1 = Console.ReadLine();
            Console.Write("Now the second number: ");
            userNumber2 = Console.ReadLine();
            Console.Write("And finally, tell me the last number: ");
            userNumber3 = Console.ReadLine();

            //Convert to int
            number1 = Convert.ToInt32(userNumber1);
            number2 = Convert.ToInt32(userNumber2);
            number3 = Convert.ToInt32(userNumber3);

            //Check and print results
            if (number1 + number2 == number3)
            {
                Console.WriteLine("Is possible :)");
            }
            else if (number2 + number3 == number1)
            {
                Console.WriteLine("Is possible :)");
            }
            else if (number1 + number3 == number2)
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
