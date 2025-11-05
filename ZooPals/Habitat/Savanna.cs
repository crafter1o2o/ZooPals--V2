using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal.Habitat
{
    internal class Savanna : Habitat
    {

        public double GrasslandArea;
        public int WaterHoles;

        public Savanna(string name, int capacity, double size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            return;
        }

        public CanAccommodate(Animal animal, double size)
        {
            return true;
        }

        public void AddAnimal()
        {
            
        }

        public void DisplayInfo()
        {

        }

        public void PerformMaintenance()
        {

        }
    }
}
