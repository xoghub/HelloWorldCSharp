using System;

namespace MathLib
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Max number between 10 and 20 is: {0} ", Math.Max(10, 20));
            Console.WriteLine("Min number between 10 and 20 is: {0} ", Math.Min(10, 20));
            Console.WriteLine("Pow number of 10 to power 3 is: {0} ", Math.Pow(10, 3));
            Console.WriteLine("Sqrt number of 16 is: {0} ", Math.Sqrt(16));
            Console.WriteLine("Abs number of -16 is: {0} ", Math.Abs(-16));
            Console.WriteLine("Round number of 6.12344 is: {0} ", Math.Round(6.12344));
            Console.WriteLine("Log number of 10 is: {0} ", Math.Log(10));
            Console.WriteLine("Exp number of 10 is: {0} ", Math.Exp(10));
            
        }
    }
}