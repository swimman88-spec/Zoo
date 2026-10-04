using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Extra utmaning: människan ingår bland däggdjuren.
    public class Human : Mammal
    {
        // Människans egen egenskap.
        public string Language { get; set; }

        public Human(
            string name = "Anna",
            int age = 25,
            double weight = 65,
            string color = "Brun",
            bool isWild = false,
            string language = "Svenska")
            : base(name, age, weight, color, isWild)
        {
            Language = language;
        }

        // Människans egen metod.
        public void Speak()
        {
            Console.WriteLine($"{Name} talar {Language}.");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name}: Hej!");
        }
    }
}