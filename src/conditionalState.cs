using System;

namespace HelloWorldCSharp
{
    public class ConditionalState
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            IfElseStatement(number);
            SwitchStatement(number);
        }
        
        public static void IfElseStatement(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        public static void SwitchStatement(int number)
        {
            switch (number % 2)
            {
                case 1:
                    Console.WriteLine("The number is odd.");
                    break;
                case 0:
                    Console.WriteLine("The number is even.");
                    break;
                default:
                    Console.WriteLine($"The number is {number}.");
                    break;
            }
        }
    }
}