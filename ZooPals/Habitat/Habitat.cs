using System;
using System.Collections.Generic;

namespace ZooPals.Habitat
{
    internal class Habitat
    {
        public string Name;
        public string Type;
        public int Capacity;
        public double Temperature;
        public double Size;

        List<String> Animals = new List<String>();

        public Habitat(string name, string type, int capacity, double temperature, double size)
        {

        }

        public virtual void CanAccommodate()
        {

        }

        public void AddAnimal()
        {
            
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Habitat Name: {Name}, Type: {Type}, Capacity: {Capacity}, Temperature: {Temperature}, Size: {Size}");
        }

        public void PerformMaintenance()
        {

        }
    }
}
