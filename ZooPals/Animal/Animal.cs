using System;

namespace ZooPal
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public double Weight;
        public bool IsHealthy;
        public DateTime LastFedTime;
        public string HabitatType;

        public Animal(string name, int age, double weight, bool IsHealthy, string HabitatType)
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

        public double GetFoodAmount()
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
