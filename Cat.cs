using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Cat : Animal 
    {
        private bool Feral;
        public Cat(string species = "cat", int limbs = 4, 
                    float height = 20, float weight = 5, 
                    int age = 5, int heartRate = 90, bool feral = false)
        : base(species, limbs, height, weight, age, heartRate)
        {
            Feral = feral; 
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void ScratchFurniture()
        {
            Console.WriteLine("The cat is scratching the furniture.");
        }
    }
}
