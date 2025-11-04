using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animals
{
    internal class Mammal : Animal {
        bool isSocial;
        int gestationDays;

        public Mammal(String name, int age, double weight, bool healthy, String habitat, bool isSocial, int gestationDays) 
            : base(name, age, weight, healthy, habitat)
        {
            this.isSocial = isSocial;
            this.gestationDays = gestationDays;
        }
    }
}
