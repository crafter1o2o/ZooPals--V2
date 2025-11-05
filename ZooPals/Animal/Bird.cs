using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal.Animals;

namespace ZooPals.Animals
{
    internal class Bird : Animal{
        bool canFly;
        double wingSpan;
        public Bird(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan) : base(name, age, weight, healthy, habitat)
    {
        public int EggsPerYear;
        public bool canFly;
        public double wingSpan;
        public Bird(String name, int age, double weight, bool isHealthy, String HabitatType, bool canFly, double wingSpan, int annualEggs) : base(name,age,weight,isHealthy,HabitatType)
        {
            this.EggsPerYear = annualEggs;
            this.canFly = canFly;
            this.wingSpan = wingSpan;
        }

        }
    }
}
