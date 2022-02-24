using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string userNumber1;
            string userNumber2;
            int number1;
            int number2;

            //Read user input to variables
            Console.Write("Hello, please tell me a integer: ");
            userNumber1 = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Now, tell me one more integer: ");
            userNumber2 = Console.ReadLine();
            Console.Write("\n");

            //Convert string to integer
            number1 = StringConvertInt(userNumber1);
            number2 = StringConvertInt(userNumber2);

            //Print results
            Console.WriteLine($"Adding the two numbers given results " + 
            "in {number1 + number2}");
        }

        static int StringConvertInt(string s)
        {
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //adds the number in position i of the string to temp multiplying it by the correct power
                temp += (s.ToCharArray()[i] - 48) * (int)Math.Pow(10, s.Length - 1 - i);
            }

            return temp;
        }
    }
}
