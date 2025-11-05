using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal.Animal.ZooPal.Animals;

namespace ZooPal.Animals
{
    internal class Bear : Mammal
    {
        bool likesHoney;

        public Bear(String name, int age, double weight, bool healthy, String habitat, bool isSocial, int gestationDays, bool likesHoney):base(name, age, weight, healthy, habitat, isSocial, gestationDays)
        {
            this.likesHoney = likesHoney;
        }
    }
    
}
