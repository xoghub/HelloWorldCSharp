using System;

namespace HelloWorldCSharp
{
    public class hypotenuseCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the hypotenuse of a right-angled triangle.");

            Console.Write("Enter the length of side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.Write("Enter the length of side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine() ?? "0");

            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine($"The length of side A is: {sideA}");
            Console.WriteLine($"The length of side B is: {sideB}");
            Console.WriteLine($"The length of the hypotenuse is: {hypotenuse}");
        }
    }
}