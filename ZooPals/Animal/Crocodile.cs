using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animals
{
    internal class Crocodile : Reptile
    {   double Biteforce;
        int TeethCount;
         public Crocodile(String name, int age, double weight, bool healthy, String habitat, bool isColdBlooded, bool hasScales, double biteforce, int teethCount)
        : base(name, age, weight, healthy, habitat, isColdBlooded, hasScales)
        {
            this.Biteforce = biteforce;
            this.TeethCount = teethCount;
        }
    }
}