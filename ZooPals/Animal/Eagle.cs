using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPals.Animal;

namespace ZooPals.Animal
{
    internal class Eagle : Bird
    {
        public double DiveSpeed;
        public double VisualAcuity;

        public Eagle(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan, double diveSpeed, double visualAcuity, int EggsPerYear)
            : base(name, age, weight, healthy, habitat, canFly, wingSpan, EggsPerYear)
        {
            this.DiveSpeed = diveSpeed;
            this.VisualAcuity = visualAcuity;

        }

        public string MakeSound()
        {
            return "Screech";
        }

        public string GetDietType()
        {
            return "Carnivore";
        }

        public double GetFoodAmount()
        {
            return Weight * 0.25;
        }

        public void Feed()
        {

        }

        public void DisplayInfo()
        {

        }
    }
}
