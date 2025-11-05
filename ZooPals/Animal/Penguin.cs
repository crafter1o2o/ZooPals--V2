using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    internal class Penguin : Bird
    {
        public double SwimSpeed { get; set; }
        public int ColonySize { get; set; }

        public Penguin(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan, int EggsPerYear, double SwimSpeed,int ColonySize):base (name, age, weight, healthy, habitat, canFly, wingSpan, EggsPerYear)
        {
            this.SwimSpeed = SwimSpeed;
            this.ColonySize = ColonySize;
        }
        public string MakeSound()
        {
            return "Honk";
        }

        public string GetDietType()
        {
            return "Fish";
        }

        public double GetFoodAmount()
        {
            return Weight * 0.25;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the penguin has been fed {GetFoodAmount()} kg of fish.");
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Swim Speed: {SwimSpeed}, Colony Size: {ColonySize}");
        }

    }

}
