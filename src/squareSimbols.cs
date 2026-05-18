using System;

namespace HelloWorld
{
    class SquareSimbols
    {
        public static void Main(string[] args)
        {
            squareSimbolsFunction();
        }

        public static void squareSimbolsFunction()
        {
            Console.Write("Enter a number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int index = 1; index <= columns; index++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}