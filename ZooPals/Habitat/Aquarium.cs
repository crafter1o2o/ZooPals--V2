using System;
using System.Collections.Generic;

namespace ZooPals.Habitat
{
    internal class Aquarium : Habitat
    {
        public double WaterVolume;
        public double SalinityLevel;
        public bool HasUnderWaterViewing;

        public Aquarium(double waterVolume, double salinityLevel, bool hasUnderWaterViewing) :base(string name, string, int capacity, double temperature, double size)
        {
            WaterVolume = waterVolume;
            SalinityLevel = salinityLevel;
            HasUnderWaterViewing = hasUnderWaterViewing;
        }

        public bool CanAccommodate(Animal animal)
        {

        }

        public void AddAnimal(Animal animal)
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
