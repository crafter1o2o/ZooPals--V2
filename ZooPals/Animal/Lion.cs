using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    internal class Lion : Mammal
    {
        public int prideSize;
        bool isAlpha;

        public Lion(string name, int age, double weight, bool healthy, String habitat, bool isSocial, int gestationDays, int prideSize, bool isAlpha) 
            : base(name, age, weight, healthy, habitat, isSocial, gestationDays)
        {
            this.prideSize = prideSize;
            this.isAlpha = isAlpha;
        }

            public void MakeSound()
        {
            Console.WriteLine("Roar!");
            return;
        }

        public string GetDietType()
        {
            return "Carnivore";
        }

        public double GetFoodAmount()
        {
            return Weight * 0.25;
        }

        public void setName(string name)
        {
            Name = name;
            return;
        }

        public string getName()
        {
            return Name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the lion has been fed {GetFoodAmount()} kg of meat.");
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Pride Size: {prideSize}, Is Alpha: {isAlpha}");
        }
    }
}