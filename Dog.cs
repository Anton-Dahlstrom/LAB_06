using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Dog : Animal 
    {
        private bool _neutered;
        public Dog(string species = "dog", int limbs = 4, 
                    float height = 40, float weight = 10, 
                    int age = 5, int heartRate = 80, bool neutered = false)
        : base(species, limbs, height, weight, age, heartRate)
        {
            _neutered = neutered; 
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
        public void Neuter()
        {
            if (_neutered)
            {
                Console.WriteLine("The dog is already neutered");
                return;
            }
            Neutered = true;
            Console.WriteLine("The dog has been neutered");
        }
    }
}
