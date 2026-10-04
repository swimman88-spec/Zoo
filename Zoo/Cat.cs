using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Cat ärver från Mammal och därmed också från Animal.
    public class Cat : Mammal
    {
        // Kattens egen egenskap.
        public bool LikesClimbing { get; set; }

        public Cat(
            string name = "Misse",
            int age = 2,
            double weight = 4,
            string color = "Svart",
            bool isWild = false,
            bool likesClimbing = true)
            : base(name, age, weight, color, isWild)
        {
            LikesClimbing = likesClimbing;
        }

        // Kattens egen metod.
        public void Climb()
        {
            if (LikesClimbing)
            {
                Console.WriteLine($"{Name} klättrar i ett träd.");
            }
            else
            {
                Console.WriteLine($"{Name} stannar på marken.");
            }
        }

        // Ersätter det ärvda ljudet med kattens ljud.
        public override void makeSound()
        {
            Console.WriteLine($"{Name}: Mjau!");
        }
    }
}