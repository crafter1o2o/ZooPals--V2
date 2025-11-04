using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animals
{
    internal class Reptile : Animal
    {
        bool isColdBlooded;
        bool hasScales;

        public Reptile(String name, int age, double weight, bool healthy, String habitat, bool isColdBlooded, bool hasScales)
            : base(name, age, weight, healthy, habitat)
        {
            this.isColdBlooded = isColdBlooded;
            this.hasScales = hasScales;
        }
    }
}
