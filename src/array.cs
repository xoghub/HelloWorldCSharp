using System;

namespace HelloWorld{
    class Array{
        public static void Main(string[] args){
            // ARRAY IS VARIABLE THAT CAN STORE MULTIPLE VALUES WITH FIXED SIZE.
            
            String[] candys = {"KitKat", "Snickers", "Mars", "Twix", "Kinder"};

            for (int index = 0; index < candys.Length; index++){
                Console.WriteLine("using for " + candys[index]);
            }

            // reassign
            candys[0] = "Skittles";

            foreach (String candy in candys){
                Console.WriteLine("after reassign " + candy);
            }
        }
    }
}