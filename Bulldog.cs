using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Bulldog : Dog
    {
        private int _snoringLevel;
        public Bulldog(int snoringLevel = 5, string species = "Bulldog", int limbs = 4, 
                    float height = 40, float weight = 23, 
                    int age = 5, int heartRate = 80, bool neutered = false)
        : base(species, limbs, height, weight, age, heartRate)
        {
            _snoringLevel = snoringLevel; 
        }
        public void Snore()
        {
            Console.WriteLine($"The bulldog is snoring at a level {_snoringLevel} intensity.");
        }
    }
}
