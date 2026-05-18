using System;

namespace HelloWorld{
    class ConditionalOperator{
        public static void Main(string[] args){
            /*
            Conditional Operator (?:)
            It is a ternary operator that is used to evaluate a condition and return a value based on the condition.
            Syntax:
            condition ? value_if_true : value_if_false
            */

            try {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = (num >= 0) ? "Positive" : "Negative";
            Console.WriteLine(result);
            } catch (FormatException e) {
                Console.WriteLine("Error : Enter Must be a Number.\n" + e.Message);
            } catch (OverflowException e) {
                Console.WriteLine("Error : Input Value Is Too Big.\n" + e.Message);
            } finally {
                Console.WriteLine("Program Finished!");
            }
        }
    }
}