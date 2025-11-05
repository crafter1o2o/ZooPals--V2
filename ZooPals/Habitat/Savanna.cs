using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Habitat
{
    internal class Savanna : Habitat
    {

        public double GrasslandArea;
        public int WaterHoles;

        public Savanna(string name, string type, int capacity, double temperature, double size, double GrasslandArea, int WaterHoles) : base(name, type, capacity, temperature, size)
        {
            this.GrasslandArea = GrasslandArea;
            this.WaterHoles = WaterHoles;
            
            return;
        }

        override
            public void CanAccommodate()
        {
            bool CanAccommodate = true;
            return;
        }

        public void AddAnimal()
        {
            
        }
        override
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Grassland Area: {GrasslandArea}, Water Holes: {WaterHoles}");

        }

        public void PerformMaintenance()
        {

        }
    }
}
