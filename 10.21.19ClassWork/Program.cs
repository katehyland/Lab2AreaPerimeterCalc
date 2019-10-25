using System;

namespace _10._21._19ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            //prompt user to enter a length
            Console.WriteLine("Enter a length");
            string inputLength = Console.ReadLine();
            double length = Double.Parse(inputLength);

            //prompt user to enter a width
            Console.WriteLine("Enter a width");
            string inputWidth = Console.ReadLine();
            double width = Double.Parse(inputWidth);

            //calculate area 
            double area = length * width;

            //calculate perimeter
            double perimeter = ((length*2) + (width*2));

            //Display area
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The perimeter is: " + perimeter);

        }
    }
}
