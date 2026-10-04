using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Mammal ärver från Animal och representerar däggdjur.
    public class Mammal : Animal
    {
        public Mammal(
            string name = "Okänt däggdjur",
            int age = 0,
            double weight = 1,
            string color = "Okänd",
            bool isWild = true)
            : base(name, age, weight, color, isWild)
        {
        }

        // En metod som är gemensam för däggdjur.
        public void FeedMilk()
        {
            Console.WriteLine($"{Name} ger mjölk till sina ungar.");
        }
    }
}
