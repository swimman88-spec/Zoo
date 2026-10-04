using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Reptile ärver från Animal och representerar reptiler.
    public class Reptile : Animal
    {
        public Reptile(
            string name = "Okänd reptil",
            int age = 0,
            double weight = 1,
            string color = "Okänd",
            bool isWild = true)
            : base(name, age, weight, color, isWild)
        {
        }

        // En metod som är gemensam för reptiler.
        public void BaskInSun()
        {
            Console.WriteLine($"{Name} värmer sig i solen.");
        }
    }
}
