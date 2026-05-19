using System;

namespace HelloWorld{
    public class Messages {
        public static void sayHello(string name = "User"){
            Console.WriteLine("Hello " + name);
        }

        public static void sayGoodbye(string name = "User"){
            Console.WriteLine("Goodbye " + name);
        }
    }
}