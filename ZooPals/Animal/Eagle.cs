using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPals.Animals;

namespace ZooPal.Animals
{
    internal class Eagle : Bird
    {
        public double DiveSpeed;
        public double VisualAcuity;

        public Eagle(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan, double diveSpeed, double visualAcuity)
            : base(name, age, weight, healthy, habitat, canFly, wingSpan)
        {
            this.DiveSpeed = diveSpeed;
            this.VisualAcuity = visualAcuity;

        }

        public string MakeSound()
        {

        }

        public string GetDietType()
        {

        }

        public double GetFoodAmount()
        {

        }

        public void Feed()
        {

        }

        public void DisplayInfo()
        {

        }
    }
}
