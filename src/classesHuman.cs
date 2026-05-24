using System;

namespace HelloWorld {
    public static class HumanBreeding {
        public static void Main(string[] args) {
            System.Console.WriteLine("Hello World");

            Human male = new Human(
                firstName: "John",
                lastName: "Hanibal",
                age: 25,
                gender: "Male",
                skills: new string[] {"Programming", "Swimming", "Running"},
                jobs: new string[] {"Engineer", "Developer", "Researcher"},
                height: 170,
                weight: 60,
                tribes: "Batak Toba"
            );

            Human female = new Human(
                firstName: "Jane",
                lastName: "Doe",
                age: 22,
                gender: "Female",
                skills: new string[] {"Gardening", "Cooking", "Farming"},
                jobs: new string[] {"Farmer", "Housewife", "Gardener"},
                height: 160,
                weight: 50,
                tribes: "Africa"
            );

            string mating = Human.Mating(male, female);
            Console.WriteLine(mating);
        }
    }

    public class Human {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Gender;
        public string[] Skills;
        public string[] Jobs;
        public int Height; 
        public int Weight;
        public string Tribes;

        public Human(string firstName, string lastName, int age, string gender, string[] skills, string[] jobs, int height, int weight, string tribes){
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Skills = skills;
            this.Jobs = jobs;
            this.Height = height;
            this.Weight = weight;
            this.Tribes = tribes;
        }

        public static void SayHello() {
            System.Console.WriteLine("Hello World");
        }

        public static string Mating(Human male, Human female) {
            return $"Human {male.FirstName} {male.LastName} and {female.FirstName} {female.LastName} Mating";
        }
    }
}