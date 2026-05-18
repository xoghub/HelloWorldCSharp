using System;

namespace HelloWorld{
    class StringInterpolation{
        public static void Main(string[] args){
            /*
            String Interpolation
            String Interpolation is a feature of C# that allows you to create formatted strings.
            Syntax:
            $"string with {variable}"
            */
            bool isValid = false;
            try {
                Console.Write("Enter your name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Hello {name}, you are {age} years old.\n");
                isValid = true;
            } catch(FormatException e){
                isValid = false;
                Console.WriteLine("Error : Name Must be a String \n Age Must be a Number.\n" + e.Message + "\n");
            }catch(OverflowException e){
                isValid = false;
                Console.WriteLine("Error : Age value is too large.\n" + e.Message + "\n");
            }finally{
                string status = $"Result: {(isValid ? "Pass" : "Fail")}";
                Console.WriteLine(status);
                Console.WriteLine("Program Finished!");
            }
        }
    }
}