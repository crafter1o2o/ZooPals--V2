using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal;
using ZooPals.Animal;



namespace ZooPal
{
    internal class Program
    {




        static void Main(string[] args)
        {


            //List for the ALL animals
            List<Animal> listAnimals = new List<Animal>();



            //Create the Animal of choice
            Animal Leo = new Lion("Leo", 5, 190.5, true, "Savannah", true, 100, 3,true);
            Animal Ella = new Elephant("Ella", 10, new Random().Next(2000, 6000), true, "Grassland", true, 640, 2.0, 1.5);
            Animal Corrie = new Eagle("Corrie", 4, 15.0, true, "Mountains", true, 2.0, 320.0, 8.0, 4);
            Animal Koda  = new Crocodile("Koda", 7, 500.0, true, "Swamp", true, false, 5, 2000.0, 60);
            Animal Manny = new Penguin("Manny", 3, 30.0, true, "Arctic", false, 0.5, 20, 10.0, 50);
            
            Leo.DisplayInfo();
            Ella.DisplayInfo();
            Corrie.DisplayInfo();
            Koda.DisplayInfo();
            Manny.DisplayInfo();
            

            //Add the animal to the list
            ///I Unfortunately don't know how to automatically add animals to habitats yet, so for now it's manual. -PCB
            ///
            listAnimals.Add(Leo);
            listAnimals.Add(Ella);
            listAnimals.Add(Corrie);
            listAnimals.Add(Koda);
            listAnimals.Add(Manny);





            //Create Habitats
            ///I will be figuring out how to add animals to habitats automatically later. For now, it's manual. -PCB
            //Habitat savannahHabitat = new Savannah("Savannah", 10, 30.0, 5000.0, true);

            //To Stop The Program, Make this bish false
            bool isRunning = true;


            //Take user input
            String userInput;
            string userInput1;

            /*
                        String userStrimg1 = "DefaultName";
                        String userString2 = "DefaultSpecies";
                        int userInt1 = 0;
                        double userDouble1 = 0.0;
                        bool userBoolean1 = true;

            */
            while (isRunning == true)
            {
                //Makes the menu display
                UI.DisplayMenu();

                Console.Write("Please select an option (1-9): ");
                userInput = Console.ReadLine();
                userInput1 = userInput;
                ///YES I KNOW IT'S REPEATIVE! BUT THIS IS WORKING!!! -PCB

                Console.Clear();
                switch (userInput1)
                {
                    case "1":
                        for (int i = 0; i < listAnimals.Count(); i++)
                        {
                            Console.WriteLine(listAnimals[i]);
                        }

                        //Display Animals
                        userInput = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        //Display Habitats

                        Console.Clear();
                        //Console.WriteLine(savannahHabitat.displayInfo());
                        //Currently, no animals being made are being adding animals to habitat, fix that somehow, figuture it out soon.
                        break;
                    case "3":

                        Console.Clear();
                        //Feed All Animals
                        break;
                    case "4":

                        Console.Clear();
                        //Perform Health Checks
                        break;

                    case "5":

                        Console.Clear();
                        //Add New Animal
                        break;
                    case "6":

                        Console.Clear();
                        //Generate Daily Report
                        break;
                    case "7":

                        Console.Clear();
                        //Emergency Evacuation Drill
                        break;
                    case "8":

                        Console.Clear();

                        break;
                    case "9":

                        ///GOD DAMNIT! This stupid POS won't read this for some reason.
                        ///10-22 FIXED IT!!! WOOOOOO!!! Also I did just change the case for this cause I finally realized I didn't make the Main Menu Properly-PCB
                        //Exit
                        Console.Clear();
                        Console.WriteLine("Exiting the program. Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;

                }
            }
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




