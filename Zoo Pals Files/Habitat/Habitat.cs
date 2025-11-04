using System;
using System.Collections.Generic;
using ZooPal_LikeThePlates_.Animals;

namespace ZooPal_LikeThePlates_.Habitat
{
    internal class Habitat
    {
        // Fields
        private string biome;
        private int capacity;
        private double temperature;
        private double size;
        private bool isClean;
        private List<Animal> animalsInHabitat;

        public Habitat(string biome, int capacity, double temperature, double size, bool isClean)
        {
            this.biome = biome;
            this.capacity = capacity;
            this.temperature = temperature;
            this.size = size;
            this.isClean = isClean;
        }
        // Display info about the habitat
        public string DisplayInfo()
        {
            return $"Biome: {biome}, Capacity: {capacity}, Temperature: {temperature}°C, Size: {size} sqm, Clean: {isClean}";
        }







        // Add animal safely (no infinite recursion!)
        public void AddAnimalToHabitat(Animal animalToAdd)
        {
            if (animalsInHabitat.Count < capacity)
            {
                animalsInHabitat.Add(animalToAdd);
                Console.WriteLine($"{animalToAdd.Name} added to {biome} habitat.");
            }
            else
            {
                Console.WriteLine("Habitat is at full capacity!");
            }
        }
    }
}
