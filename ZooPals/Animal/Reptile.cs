using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    public abstract class Reptile : Animals
    {
        public bool isColdBlooded;
        public bool isVenomous;
        public int SheddingFrequency;

        public Reptile(String name, int age, double weight, bool isVenomous, bool isHealthy, DateTime lastFed, String habitat, bool isColdBlooded, bool Venomous, int shedRate) : base(name, age, weight, isHealthy, lastFed, habitat)
        {
            this.isColdBlooded = isColdBlooded;
            this.isVenomous = Venomous;
            this.SheddingFrequency = shedRate;
        }
    }
}
