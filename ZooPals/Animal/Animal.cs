using System;

namespace ZooPals.Animal
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public bool IsHealthy = true;

        public DateTime LastFedTime = DateTime.Now;
        public string? HabitatType { get; set; }

        // Constructor
        public Animal(string name, int age, double weight, bool isHealthy, string habitatType)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
            HabitatType = habitatType;
        }

        // Make this method overridable by derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine(
                $"Name: {Name}, Age: {Age}, Weight: {Weight} kg, Healthy: {IsHealthy},  Habitat: {HabitatType}"
            );
        }

        public void Feed()
        {

        }

        public void PerformHealthCheck()
        {

        }

        public void UpdateHealth(bool healthStatus)
        {
            IsHealthy = healthStatus;
            Console.WriteLine($"{Name}'s health status updated to: {IsHealthy}");
        }
    }
}
