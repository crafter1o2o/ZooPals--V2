using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animals
{
    internal class Reptile : Animal
    {
        public bool isColdBlooded;
        public bool isVenomous;
        public int SheddingFrequency;

        public Reptile(String name, int age, double weight, bool healthy, String habitat, bool isColdBlooded, bool hasScales)
            : base(name, age, weight, healthy, habitat)
        {
            this.isColdBlooded = isColdBlooded;
            this.isVenomous = Venomous;
            this.SheddingFrequency = shedRate;
        }
    }
}
