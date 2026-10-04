using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Chihuahua ärver från Dog.
    public class Chihuahua : Dog
    {
        // Chihuahuans unika egenskap.
        public bool GetsColdEasily { get; set; }

        // Standardvärden skickas till konstruktorn i Dog.
        public Chihuahua(
            string name = "Coco",
            bool getsColdEasily = true)
            : base(name, 2, 2, "Beige", false, "Chihuahua")
        {
            GetsColdEasily = getsColdEasily;
        }

        // Chihuahuans unika metod.
        public void Shiver()
        {
            if (GetsColdEasily)
            {
                Console.WriteLine($"{Name} darrar av kyla.");
            }
            else
            {
                Console.WriteLine($"{Name} känner sig varm.");
            }
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name}: Voff! Voff! Voff!");
        }
    }
}