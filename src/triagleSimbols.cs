using System;

namespace HelloWorld{
    class TriagleSimbols{
        public static void Main(string[] args){
            rightTriagleSimbols();
            centeredTriagleSimbols();
            leftTriagleSimbols();
        }

        public static void rightTriagleSimbols(){
            Console.Write("Enter a number of length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int index = 1; index <= length; index++){
                for (int j = 1; j <= index; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void centeredTriagleSimbols(){
            Console.Write("Enter a number of length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int index = 1; index <= length; index++){
                for (int j = 1; j <= length - index; j++){
                    Console.Write(" ");
                }
                for (int j = 1; j <= index; j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void leftTriagleSimbols(){
            Console.Write("Enter a number of length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int index = 1; index <= length; index++){
                for (int k = length; k >= index; k--){
                    Console.Write(" ");
                }
                for (int j = 1; j <= index; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}