using System;

namespace HelloWorld{
    class Classes{
        public static void Main(string[] args){
            Person person = new Person("John", 25, "Engineer");
            person.sayHi();
            Console.WriteLine(person.getInfo());
            Console.WriteLine(person.walk("Home"));
            Console.WriteLine(person.run("Work"));

            // We don't need to import anything since both are in namespace HelloWorld
            // We call these directly because they are 'static' methods
            Messages.sayHello();
            Messages.sayGoodbye();
        }
    }

    class Person{
        public string name;
        public int age;
        public string job;

        public Person(string name, int age, string job){
            this.name = name;
            this.age = age;
            this.job = job;
        }

        public void sayHi(){
            Console.WriteLine($"Hello {name}, you are {age} years old and your job is {job}.");
        }

        public string getInfo(){
            return $"Name: {name}\nAge: {age}\nJob: {job}";
        }

        public string walk(string destination){
            return $"The person {name} is walking to {destination}.";
        }

        public string run(string destination){
            return $"The person {name} is running to {destination}.";
        }
    }
}
