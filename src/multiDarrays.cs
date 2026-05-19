using System;

namespace HelloWorld{
    class MultiDArrays{
        public static void Main(string[] args){
            /*
            Multi-Dimensional Arrays
            Multi-dimensional arrays are arrays that have more than one dimension.
            Syntax:
            datatype[,] arrayName = new datatype[rows, columns]; # length is fixed
            */
            string[] berries = {"Strawberry", "Blueberry", "Raspberry", "Blackberry", "Banana", "Orange"};
            string[] apples = {"Granny Smith", "Red Delicious", "Gala", "Fuji", "Malang", "Avocado"};
            string[,] fruits = new string[2, berries.Length];

            try {
                if (checkLength(berries, apples)){
                    for (int i = 0; i < berries.Length; i++){
                        fruits[0, i] = berries[i];
                        fruits[1, i] = apples[i];
                    }

                    for (int i = 0; i < fruits.GetLength(0); i++){
                        for (int j = 0; j < fruits.GetLength(1); j++){
                            Console.Write(fruits[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                } else {
                    Console.WriteLine("Error : Arrays Must Be Same Length");
                }
            } catch (Exception e) {
                Console.WriteLine("Error : " + e.Message);
            } finally {
                Console.WriteLine("Program Finished!");
            }
        }

        public static bool checkLength(string[] arr1, string[] arr2){
            return arr1.Length == arr2.Length;
        }
    }
}