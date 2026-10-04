using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Bulldog ärver från Dog.
    // Bulldog får också egenskaper och metoder från Dogs basklasser.
    public class Bulldog : Dog
    {
        // Bulldoggens unika egenskap.
        public bool HasWrinkles { get; set; }

        // Standardvärden skickas till konstruktorn i Dog.
        public Bulldog(
            string name = "Bruno",
            bool hasWrinkles = true)
            : base(name, 4, 25, "Vit", false, "Bulldog")
        {
            HasWrinkles = hasWrinkles;
        }

        // Bulldoggens unika metod.
        public void Snore()
        {
            Console.WriteLine($"{Name} snarkar.");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name}: VOFF VOFF!");
        }
    }
}