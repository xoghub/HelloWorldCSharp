using System;

namespace HelloWorld{
    class ExceptionHandling{
        public static void Main(string[] args){
            double x;
            double y;
            try {
                Console.Write("Enter a number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b number: ");
                y = Convert.ToDouble(Console.ReadLine());
                double sum = sumCatch(x,y);
                Console.WriteLine("Result: " + sum);
            }catch(FormatException e){
                Console.WriteLine("Error : Enter Must be a Number.\n" + e.Message);
            }finally{
                Console.WriteLine("Try Run Program Again");
            }
        }

        public static double sumCatch(params double[] args){
            double sum = 0;
            foreach (double arg in args){
                sum += arg;
            }
            return sum;
        }
    }
}
