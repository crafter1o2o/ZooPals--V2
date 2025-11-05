using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animal
{
    internal class Mammal : Animal 
    {
        
        bool isSocial;
        int gestationDays;

        public Mammal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat, bool isSocial, int gestationDays) :base(name ,age, weight, healthy, lastFed, habitat, name)
        {
            this.isSocial = isSocial;
            this.gestationDays = gestationDays;

        }





    }
}
