using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Dog ärver från Mammal och därmed också från Animal.
    public class Dog : Mammal
    {
        // Hundens egen egenskap.
        public string Breed { get; set; }

        public Dog(
            string name = "Max",
            int age = 3,
            double weight = 20,
            string color = "Brun",
            bool isWild = false,
            string breed = "Blandras")
            : base(name, age, weight, color, isWild)
        {
            Breed = breed;
        }

        // Hundens egen metod.
        public void Fetch()
        {
            Console.WriteLine($"{Name} hämtar en boll.");
        }

        // Ersätter det ärvda ljudet med hundens ljud.
        public override void makeSound()
        {
            Console.WriteLine($"{Name}: Vov vov!");
        }
    }
}
