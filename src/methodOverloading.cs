using System;

namespace HelloWorld{
    class MethodOverloading{
        /*
        Method Overloading is a feature of object-oriented programming that allows you to define multiple
        methods in a class with the same name but with different parameters. 
        The compiler determines which method to call based on the arguments passed to the method.
        Note:
        1. Method name must be same
        2. Parameters must be different
        3. Signature must be unique
        */
        public static void Main(string[] args){
            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1.11, 2.22, 3.33));
        }

        public static int add(int a, int b){
            return a + b;
        }
        public static double add(double a, double b, double c){
            return a + b + c;
        }
    }
}