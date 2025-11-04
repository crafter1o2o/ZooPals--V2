using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal_LikeThePlates_.Habitat
{
    internal class Savannah : Habitat
    {
        private double GrassCoverage;
        private int WateringHole;

        public Savannah(string biome, int capacity, double temperature, double size, bool isClean, double grassCoverage, int wateringHole)
            : base(biome, capacity, temperature, size, isClean)
        {
            this.GrassCoverage = grassCoverage;
            this.WateringHole = wateringHole;
        }


        /*
    public string DisplayInfo
    {
        get
        {
           :base.DisplayInfo();
            return $"{DisplayInfo()}, Grass Coverage: {GrassCoverage}%, Watering Hole Count: {WateringHole}";
        }
        */
    }
}
