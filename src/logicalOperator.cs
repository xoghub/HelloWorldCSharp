using System;

namespace HelloWorldCSharp
{
    public class LogicalOperator
    {
        public static void Main(string[] args)
        {
            /*
            && -> AND
            || -> OR
            ! -> NOT
            */
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            LogicalOperatorFunction(number1, number2);
        }
        
        public static void LogicalOperatorFunction(int number1, int number2)
        {
            if (!(number1 > 0))
            {
                Console.WriteLine("The first number is negative.");
            }

            if (!(number2 > 0))
            {
                Console.WriteLine("The second number is negative.");
            }

            if (number1 > 0 || number2 > 0)
            {
                Console.WriteLine("At least one of the numbers is positive.");
            }

            if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("The both numbers are positive.");
            }

            if (!(number1 > 0) && !(number2 > 0))
            {
                Console.WriteLine("The both numbers are negative.");
            }
        }
    }
}
