using System;

namespace HelloWorld{
    class ParamsKeyword{
        public static void Main(string[] args){

            //PARMS KEYWORD ALLOWS YOU TO PASS VARIABLE NUMBER OF ARGUMENTS TO A METHOD
            // the parameter type must be an single dimensional array
            Console.WriteLine(add(1));
            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1, 2, 3));
            Console.WriteLine(add(1, 2, 3, 4));
            Console.WriteLine(add(1, 2, 3, 4, 5));
        }

        public static double add(params double[] numbers){
            double sum = 0;
            foreach (double number in numbers){
                sum += number;
            }
            return sum;
        }
    }
}