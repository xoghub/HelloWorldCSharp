using System;

namespace HelloWorld
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            // forLoopFunction();
            forLoopCountDown();
        }

        public static void forLoopFunction()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                Console.WriteLine(index);
            }
        }

        public static void forLoopCountDown() 
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int index = number; index >= 0; index--)
            {
                Console.WriteLine(index);
            }
        }
    }
}