using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPal
{
    internal class Preserve
    {
        String name;
        List<String> animals;
        List<String> habitats;
        DateTime OpeningTime;
        DateTime ClosingTime;
        bool isRecentlyFed;



        public Preserve(String name)
        {
            this.name = name;
            return;

        }
        public static void EmergencyEvacuation()
        {

            Console.WriteLine($"A fire has been detected!");
            Console.WriteLine($"Leo has been evacuated!");
            Console.WriteLine($"Corrie has been evacuated!");
            Console.WriteLine($"Ella has been evacuated!");
            Console.WriteLine($"Koda has been evacuated!");
            Console.WriteLine($"Manny has been evacuated!");

        }


        public void feedAllAnimals()
        {
            isRecentlyFed = true;
        }

        public void PerformHealthCheck()
        {

        }

        public void DisplayAllAnimals()
        {

        }

        public void DisplayAllHabitats()
        {

        }


        public void GenerateDailyReport()
        {

        }





    }
}