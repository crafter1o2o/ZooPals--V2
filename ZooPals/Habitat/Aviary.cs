using System;
using System.Collections.Generic;

namespace ZooPals.Habitat
{
    internal class Aviary : Habitat
    {

        public double FlightHeight;
        public int PerchCount;
        public bool HasNettingRoof;
        public Aviary(string name, string type, int capacity, double temperature, double size, double FlightHeight, int PerchCount, bool hasNettingRoof): base(name, type, capacity, temperature, size)
        {
            this.FlightHeight = FlightHeight;
            this.PerchCount = PerchCount;
            this.HasNettingRoof = hasNettingRoof;
            return;
        }   

        public void AddAnimal()
        {
            Console.WriteLine("Adding bird to the aviary.");
            // Add specific logic for adding birds to the aviary here

        }
        override
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Flight Height: {FlightHeight}, Perch Count: {PerchCount}, Has Netting Roof: {HasNettingRoof}");
        }

        public void PerformMaintenance()
        {
            Console.WriteLine($"Performing maintenance on Aviary: {Name}");
            // Add specific maintenance tasks for Aviary here
        }
    }
}
