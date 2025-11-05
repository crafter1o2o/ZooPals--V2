using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZooPal.Animal
{

	internal class Crocodile : Reptile
    {
        public double BiteForce;
        public int TeethCount;

        public Crocodile(String name, int age, double weight, bool healthy, String habitat, bool isColdBlooded, bool hasScales, double biteforce, int teethCount): base(name, age, weight, healthy, habitat, isColdBlooded, hasScales)
		{
			this.BiteForce = biteforce;
			this.TeethCount = teethCount;
        }
	
		public string MakeSound()
		{
			return "Gurrrrr";
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
