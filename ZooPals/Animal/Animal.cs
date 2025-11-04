using System;

namespace ZooPal.Animals
{
    internal class Animal
    {
        // Backing fields for properties to avoid ambiguity
        public readonly string _name;
        public readonly int _age;
        public readonly double _weight;
        public bool _isHealthy;
        public readonly string _habitatType;

        // Properties for the Animal class
        public string Name => _name;
        public int Age => _age;
        public double Weight => _weight;
        public bool IsHealthy => _isHealthy;
        public string HabitatType => _habitatType;

        // Constructor
        public Animal(string name, int age, double weight, bool isHealthy, string habitatType)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _isHealthy = isHealthy;
            _habitatType = habitatType;
        }

        // Make this method overridable by derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine(
                $"Name: {_name}, Age: {_age}, Weight: {_weight} kg, Healthy: {_isHealthy},  Habitat: {_habitatType}"
            );
        }

        /*
        public void Feed()
        {
            _lastFed = DateTime.Now;
            Console.WriteLine($"{_name} has been fed.");
        }
        */

        public void UpdateHealth(bool healthStatus)
        {
            _isHealthy = healthStatus;
            Console.WriteLine($"{_name}'s health status updated to: {_isHealthy}");
        }
    }
}

