using System;
using System.Collections.Generic;

namespace ZooPals.Habitat
{
    internal class Habitat
    {
        public string Name { get; set; }
        public string Type { get;  set; }
        public int Capacity { get; set; }
        public double Temperature { get; set; }
        public double Size { get; set; }

        List<String> Animals = new List<String>();

        public Habitat(string name, string type, int capacity, double temperature, double size)
        {
            this.Name = name;
            this.Type = type;
            this.Capacity = capacity;
            this.Temperature = temperature;
            this.Size = size;
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
