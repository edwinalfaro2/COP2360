using System;

namespace Module3Discussion
{
    class Octopus
    {
        // Regular field (mutable)
        public int Age;

        // Readonly fields (immutable after initialization)
        public readonly int Legs;
        public readonly int Eyes;

        // Regular field with private setter (encapsulation example)
        public string Name { get; private set; }

        // Constructor
        public Octopus(string name, int age)
        {
            Name = name;
            Age = age;
            Legs = 8;   // fixed value for all octopuses
            Eyes = 2;   // fixed value for all octopuses
        }

        // Method to display info
        public void DisplayInfo()
        {
            Console.WriteLine($"Octopus Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"Eyes: {Eyes}");
            Console.WriteLine("-----------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two octopus objects
            Octopus o1 = new Octopus("Edwin", 5);
            Octopus o2 = new Octopus("Josef", 3);

            // Display their info
            o1.DisplayInfo();
            o2.DisplayInfo();

            // Modify Age (mutable field)
            o1.Age = 6;
            Console.WriteLine($"{o1.Name}'s new age: {o1.Age}");

            // Try to modify readonly field (uncomment to test)
            // o1.Legs = 10; // <-- This will cause a compile-time error

            Console.ReadLine();
        }
    }
}
