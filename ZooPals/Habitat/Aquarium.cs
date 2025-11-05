using System;
using System.Collections.Generic;

namespace ZooPals.Habitat
{
    internal class Aquarium : Habitat
    {
        public double WaterVolume;
        public double SalinityLevel;
        public bool UnderwaterViewing;

        public Aquarium(string name, string type, int capacity, double temperature, double size, double WaterVolume, double SalinityLevel, bool hasUnderwaterViewing)
            : base(name, type, capacity, temperature, size)
        {
            this.WaterVolume = WaterVolume;
            this.SalinityLevel = SalinityLevel;
            this.UnderwaterViewing = hasUnderwaterViewing;
        }

        public void AddAnimal()
        {
             
        }
        override
            public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Water Volume: {WaterVolume} liters, Salinity Level: {SalinityLevel} ppt, Underwater Viewing: {UnderwaterViewing}");
            return;
        }

        public void PerformMaintenance()
        {

        }
    }
}
