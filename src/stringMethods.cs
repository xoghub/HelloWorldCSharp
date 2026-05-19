using System;

namespace HelloWorld
{
    public class StringMethods
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello World";
            string phoneNumber = "123-456-7890";
            Console.WriteLine(phoneNumber.Replace("-", ""));
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting.Contains("World"));
            Console.WriteLine(greeting.EndsWith("World"));
            Console.WriteLine(greeting.StartsWith("Hello"));
            Console.WriteLine(greeting.IndexOf("World"));
            Console.WriteLine(greeting.LastIndexOf("World"));
            Console.WriteLine(greeting.Replace("World", "C#"));
            Console.WriteLine(greeting.Insert(0, "C# "));
            Console.WriteLine(greeting.Insert(greeting.Length, " C#"));
            Console.WriteLine(greeting.Remove(0, 6));
            Console.WriteLine(greeting.Substring(6));
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.ToLower());
        }
    }
}