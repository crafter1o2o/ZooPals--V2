using System;

namespace ZooPals.Animal
{
    public abstract class Animals
    {
        public string Name;
        public int Age;
        public double Weight;
        public bool IsHealthy;
        public DateTime LastFedTime;
        public string HabitatType;

        public Animals(string name, int age, double weight, bool IsHealthy, string HabitatType)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.IsHealthy = IsHealthy;
            this.HabitatType = HabitatType;
        }

        public string MakeSound()
        {

        }

        public string GetDietType()
        {

        }

        // Make this method overridable by derived classes
        public virtual void DisplayInfo()
        {

        }

        public void Feed()
        {

        }

        public void PerformHealthCheck()
        {

        }

        public void DisplayInfo()
        {

        }
    }
}
