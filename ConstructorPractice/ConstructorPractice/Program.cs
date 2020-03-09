using System;

namespace ConstructorPractice
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.Name);
        }
    }

    public class Animal
    {
        public string Name
        {
            get;
            set;
        }

        public Animal() : this("Snoopy")
        {
        }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
