using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Extra utmaning: växter ingår också i strukturen.
    // Plant ärver från samma basklass som Animal.
    public class Plant : LivingOrganism
    {
        public double Height { get; set; }

        public Plant(
            string name = "Solros",
            double height = 1.5)
            : base(name)
        {
            Height = height;
        }

        public void Photosynthesize()
        {
            Console.WriteLine($"{Name} använder solljus för fotosyntes.");
        }
    }
}