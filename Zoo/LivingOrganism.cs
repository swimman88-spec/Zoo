using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Gemensam basklass för djur och växter.
    public class LivingOrganism
    {
        public string Name { get; set; }

        // Konstruktorn ger organismen ett namn.
        public LivingOrganism(string name = "Okänd")
        {
            Name = name;
        }

        public void Grow()
        {
            Console.WriteLine($"{Name} växer.");
        }
    }
}
