using System;

namespace HelloWorld{
    class Array{
        public static void Main(string[] args){
            // ARRAY IS VARIABLE THAT CAN STORE MULTIPLE VALUES WITH FIXED SIZE.
            
            String[] candys = {"KitKat", "Snickers", "Mars", "Twix", "Kinder"};
            String[] sortCandys = candys.OrderBy(x => x).ToArray();
            candys.Sort();

            for (int index = 0; index < candys.Length; index++){
                Console.WriteLine("sort by Sort method " + candys[index]);
            }
            for (int index = 0; index < sortCandys.Length; index++){
                Console.WriteLine("sort by OrderBy + toArray menthod " + sortCandys[index]);
            }

            // reassign
            candys[0] = "Skittles";

            foreach (String candy in candys){
                Console.WriteLine("after reassign " + candy);
            }
        }
    }
}