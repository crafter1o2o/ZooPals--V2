using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    internal class Penguin : Bird
    {
        public double SwimSpeed { get; set; }
        public int ColonySize { get; set; }

        public Penguin(string name, int age, double weight, int ColonySize, double swim)
        {
            this.SwimSpeed = swim;
            this.ColonySize = ColonySize;
        }

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

    }

}
