using System;

namespace HelloWorld
{
    class WhileLoop
    {
        public static void Main(string[] args)
        {
            whileLoopNumberFunction();
            whileLoopInputNameFunction();
        }

        public static void whileLoopNumberFunction()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < number)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void whileLoopInputNameFunction()
        {
            string name;

            Console.Write("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());

            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Enter your name: ");
                name = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("Hello, " + name);
        }
    }
}