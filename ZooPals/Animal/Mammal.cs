using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Animal
namespace ZooPal.Animals
{
    public abstract class Mammal : Animals
    {
        
        bool isSocial;
        int gestationDays;

        public Mammal(String name, int age, double weight, bool healthy, DateTime lastFed, String habitat, bool isSocial, int gestationDays) :base(name ,age, weight, healthy, lastFed, habitat, name)
        {
            this.isSocial = isSocial;
            this.gestationDays = gestationDays;

        }

        override public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Is Social: {isSocial}, Gestation Days: {gestationDays}");
        }





    }
}
