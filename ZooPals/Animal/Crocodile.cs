using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZooPals.Animal
{

	internal class Crocodile : Reptile
    {
        public double BiteForce;
        public int TeethCount;

        public Crocodile(String name, int age, double weight, bool healthy, String habitat, bool isColdBlooded, bool Venomous, int shedRate, double BiteForce, int TeethCount) : base(name, age, weight, healthy, habitat, isColdBlooded, Venomous, shedRate)
        {
			this.BiteForce = BiteForce;
			this.TeethCount = TeethCount;
        }

        override
           public void MakeSound()
        {
            Console.WriteLine("Gurrrrr!");
            return;
		}

		public string GetDietType()
		{
			return "Carnivore";
        }

		public double GetFoodAmount()
		{
			return Weight * 0.05;
        }
		public void Feed()
		{

		}
		public void DisplayInfo()
		{

		}

	}
}
