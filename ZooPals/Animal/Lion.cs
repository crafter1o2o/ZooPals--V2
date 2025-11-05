using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    internal class Lion : Mammal {


        public int PrideSize { get; set; }
        public bool IsAlpha { get; set; }

        public Lion(string Name, int Age, double Weight, int prideSize, bool isAlpha) : base(Name, Age, Weight, HabitatType, isSocial, gestationDays)
        {
            this.PrideSize = prideSize;
            this.IsAlpha = isAlpha;
        }

        public override MakeSound()
        {
            return "Roar!";
        }

        public string GetDietType()
        {
            return "Carnivore";
        }

        public double GetFoodAmount()
        {
            return Weight * 0.05;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the lion has been fed {GetFoodAmount()} kg of meat.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight} kg");
            Console.WriteLine($"Pride Size: {PrideSize}, Is Alpha: {IsAlpha}");
            Console.WriteLine($"Habitat: {HabitatType}");
        }
    }
}