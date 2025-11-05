using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal.Animals;

namespace ZooPals.Animal
{
    internal class Bird : Animal
    {
        public int EggsPerYear;
        public bool canFly;
        public double wingSpan;

        public Bird(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan, int annualEggs) : base(name, age, weight, healthy, habitat)
        {

            this.canFly = canFly;
            this.wingSpan = wingSpan;
            this.EggsPerYear = annualEggs;
        }

    }
}
