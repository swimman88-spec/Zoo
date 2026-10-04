using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Zoo
{
    // Animal ärver från LivingOrganism.
    public class Animal : LivingOrganism
    {
        // Fem gemensamma egenskaper:
        // Name ärvs från LivingOrganism.
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool IsWild { get; set; }

        // Konstruktorn har standardvärden för alla egenskaper.
        public Animal(
            string name = "Okänt djur",
            int age = 0,
            double weight = 1,
            string color = "Okänd",
            bool isWild = true)
            : base(name)
        {
            Age = age;
            Weight = weight;
            Color = color;
            IsWild = isWild;
        }

        // Gemensam metod för alla djur.
        public void Eat()
        {
            Console.WriteLine($"{Name} äter.");
        }

        // Gemensam metod för alla djur.
        public void Sleep()
        {
            Console.WriteLine($"{Name} sover.");
        }

        // Underklasser kan ändra ljudet med override.
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} gör ett ljud.");
        }
    }
}
