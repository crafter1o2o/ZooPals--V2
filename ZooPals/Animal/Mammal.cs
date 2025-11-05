using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    abstract class Mammal : Animal
    {
        
        bool isSocial;
        int gestationDays;

        public Mammal(String name, int age, double weight, bool healthy, String habitat, bool isSocial, int gestationDays) :base(name ,age, weight, healthy, habitat)
        {
            this.isSocial = isSocial;
            this.gestationDays = gestationDays;

        }

        override public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Is Social: {isSocial}, Gestation Days: {gestationDays}");
        }

        override public void MakeSound() { base.MakeSound(); }





    }
}
