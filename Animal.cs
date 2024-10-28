using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Animal
    {
        private readonly string _species;
        private readonly int _limbs;
        private readonly float _height;
        private readonly float _weight;
        private readonly int _age;
        private readonly int _heartRate;
        public Animal(string species, int limbs, float height, float weight, int age, int heartRate)
        {
            _species = species;
            _limbs = limbs;
            _height = height;
            _weight = weight;
            _age = age;
            _heartRate = heartRate;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        public void displayAgeHeartRate()
        {
            Console.WriteLine($"The {_species} has a heartrate of {_heartRate} at age {_age}.");
        }
        public void displayWeightHeight()
        {
            Console.WriteLine($"The {_species} weighs {_weight}kg and is {_height}cm tall.");
        }
        public void weightHeightRatio()
        {
            Console.WriteLine($"The {_species} has {_weight/_height} kg of weight per cm of height.");
        }
    }
    
}
