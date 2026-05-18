using System;

namespace HelloWorld{
    class MethodReturn{
        public static void Main(string[] args){
            double total = add(2.5, 3.5);
            Console.WriteLine("total " + total);
        }

        public static double add(double a, double b){
            return a + b;
        }
    }
}