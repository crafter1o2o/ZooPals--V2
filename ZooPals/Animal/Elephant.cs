using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooPal.Animals
{
    internal class Elephant :Mammal
    {

        public double TrunkLength;
        public double TuskLength;

        public Elephant(String name, int age, double weight,bool isHealthy, String habitat, bool isSocial, int gestationDays, double trunkLength, double tuskLength): 
                    base(name, age, weight, isHealthy, habitat, isSocial, gestationDays)
        {
            this.TrunkLength = trunkLength;
            this.TuskLength = tuskLength;
        }
        
        /*
        public string MakeSound()
        {

        }

        public string GetDietType()
        {

        }

        public double GetFoodAmount()
        {

        }
        public void Feed()
        {

        }

        public void DisplayInfo()
        {

        }
        */
    }
}
