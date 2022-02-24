using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            string userLength;
            string userWidth;
            string userHeight;
            float length;
            float width;
            float height;
            float result;

            Console.WriteLine("Hello, in this program we will calcolate de volume of a box.");

            //Read variables
            Console.Write("Tell me the box's height: ");
            userHeight = Console.ReadLine();
            Console.Write("Now it's length: ");
            userLength = Console.ReadLine();
            Console.Write("And finally it's width: ");
            userWidth = Console.ReadLine();

            //Convert to numbers
            length = (float)Convert.ToDouble(userLength);
            height = (float)Convert.ToDouble(userHeight);
            width = (float)Convert.ToDouble(userWidth);

            //Calcolate
            result = length * width * height;

            //Print result
            Console.WriteLine($"The box has a volume of {result:f2} m3");
        }
    }
}
