using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animals
{
    internal class Lion : Mammal
    {
        public int prideSize;
        bool isAlpha;

        private string v1;
        private int v2;
        private double v3;
        private bool v4;
        private DateTime dateTime;
        private string v6;

        public Lion(string name, int age, double weight, bool healthy, String habitat, bool isSocial, int gestationDays, int prideSize, bool isAlpha) 
            : base(name, age, weight, healthy, habitat, isSocial, gestationDays)
        {
            this.prideSize = prideSize;
            this.isAlpha = isAlpha;
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