using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Snake : Animal 
    {
        private bool Venomous;
        public Snake(string species = "snake", int limbs = 0, 
                    float height = 30, float weight = 0.5f, 
                    int age = 2, int heartRate = 55, bool venomous = false)
        : base(species, limbs, height, weight, age, heartRate)
        {
            Venomous = venomous; 
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hsssss");
        }
        public void Bite()
        {
            string danger = (Venomous) ? "venomous " : "";
            Console.WriteLine($"The snake delivers a {danger}bite");
        }
    }
}
