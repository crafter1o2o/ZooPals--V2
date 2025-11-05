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

        public void EmergencyEvacuation()
        {

        }






    }
}