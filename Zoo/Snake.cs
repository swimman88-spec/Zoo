using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Snake ärver från Reptile och därmed också från Animal.
    public class Snake : Reptile
    {
        // Ormens egen egenskap.
        public bool IsVenomous { get; set; }

        public Snake(
            string name = "Kaa",
            int age = 5,
            double weight = 8,
            string color = "Grön",
            bool isWild = true,
            bool isVenomous = false)
            : base(name, age, weight, color, isWild)
        {
            IsVenomous = isVenomous;
        }

        // Ormens egen metod.
        public void Crawl()
        {
            Console.WriteLine($"{Name} slingrar sig fram.");
        }

        // Ersätter det ärvda ljudet med ormens ljud.
        public override void makeSound()
        {
            Console.WriteLine($"{Name}: Sssss!");
        }
    }
}