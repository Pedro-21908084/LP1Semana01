using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string userNumber1;
            string userNumber2;
            float number1;
            float number2;

            //Read user input to variables
            Console.Write("Hello, please tell me a real number: ");
            userNumber1 = Console.ReadLine();

            Console.Write("Now, tell me one more: ");
            userNumber2 = Console.ReadLine();

            //Convert string to float
            number1 = (float)Convert.ToDouble(userNumber1);
            number2 = (float)Convert.ToDouble(userNumber2);

            //Print results
            Console.WriteLine($"{number1} to the power of {number2} is: " + 
            "{Math.Pow(number1, number2):f4}");
        }
    }
}
