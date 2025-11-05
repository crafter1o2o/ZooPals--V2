using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooPals.Animal;


namespace ZooPals.Animal
{
    internal class Elephant : Mammal
    {

        public double TrunkLength;
        public double TuskLength;

        public Elephant(String name, int age, double weight,bool isHealthy, String habitat, bool isSocial, int gestationDays, double trunkLength, double tuskLength): base(name, age, weight, isHealthy, habitat, isSocial, gestationDays)
        {
            this.TrunkLength = trunkLength;
            this.TuskLength = tuskLength;
        }

        override
            public void MakeSound()
        {
            Console.WriteLine("TRUMPET!");
            return;
        }
        public string GetDietType()
        {
            return "Herbivore";
        }
        public double GetFoodAmount()
        {
            return 5;
        }
        public void Feed()
        {
            Console.WriteLine($"{Name} the elephant has been fed {GetFoodAmount()} kg of hay.");
        }
  
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Trunk Length: {TrunkLength}, Tusk Length: {TuskLength}");
        }



                
    }
}
