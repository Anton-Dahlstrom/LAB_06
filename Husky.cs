using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Husky : Dog
    {
        private int _pullingStrength;
        public Husky(int pullingStrength = 10, string species = "Husky", int limbs = 4, 
                    float height = 60, float weight = 25, 
                    int age = 5, int heartRate = 80, bool neutered = false)
        : base(species, limbs, height, weight, age, heartRate)
        {
            _pullingStrength = pullingStrength; 
        }
        public void PullSled()
        {
            Console.WriteLine($"The husky is pulling the sled with {_pullingStrength} units of strength.");
        }
    }
}
