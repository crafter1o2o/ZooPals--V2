using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal;
using ZooPals.Animal;
using ZooPals.Habitat;



namespace ZooPal
{
    internal class Program
    {




        static void Main(string[] args)
        {



            //List for the ALL animals
            List<Animal> listAnimals = new List<Animal>();



            //Create the Animal of choice
            Lion Leo = new Lion("Leo", 5, 190.5, true, "Savannah", true, 100, 3,true);
            Animal Ella = new Elephant("Ella", 10, new Random().Next(2000, 6000), true, "Grassland", true, 640, 2.0, 1.5);
            Animal Corrie = new Eagle("Corrie", 4, 15.0, true, "Mountains", true, 2.0, 320.0, 8.0, 4);
            Animal Koda  = new Crocodile("Koda", 7, 500.0, true, "Swamp", true, false, 5, 2000.0, 60);
            Animal Manny = new Penguin("Manny", 3, 30.0, true, "Arctic", false, 0.5, 20, 10.0, 50);

            //Setup Habitats 
            ///TS was done at 10:32 pm. KILL ME!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Habitat Sav = new Savanna("Savanna", "Open Area", 5, 86.0, 123.45, 54.87,3);
            Habitat Air = new Aviary("Avairay","Building", 8, 77.0, 8000.0, 4000.00, 40, true);
            Habitat Swa = new Aquarium("Swamp", "Wetland", 4, 75.0, 6000.0, 12.0,0.0,true);
            



            //Add the animal to the list
            ///I Unfortunately don't know how to automatically add animals to habitats yet, so for now it's manual. -PCB
            ///
            listAnimals.Add(Leo);
            listAnimals.Add(Ella);
            listAnimals.Add(Corrie);
            listAnimals.Add(Koda);
            listAnimals.Add(Manny);

            Ella.MakeSound();






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
                     //Display Animals
                        Leo.DisplayInfo();
                        Ella.DisplayInfo();
                        Corrie.DisplayInfo();
                        Koda.DisplayInfo();
                        Manny.DisplayInfo();





                        userInput = Console.ReadLine();
                        Console.Clear();
                        break;





                    case "2":
                    //Display Habitats
                        Sav.DisplayInfo();
                        Air.DisplayInfo(); 
                        Swa.DisplayInfo();
                    
                        
                        
                     
                        userInput = Console.ReadLine();
                        Console.Clear();
                        //Console.WriteLine(savannahHabitat.displayInfo());
                        break;
                    
                    
                    
                    
                    case "3":
                    //Feed All Animals
                        Ella.Feed();
                        Leo.Feed();
                        Corrie.Feed();                        
                        Koda.Feed();
                        Manny.Feed();

                        userInput = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                     //Perform Health Checks
                        Ella.PerformHealthCheck();
                        Leo.PerformHealthCheck();
                        Corrie.PerformHealthCheck();
                        Koda.PerformHealthCheck();
                        Manny.PerformHealthCheck();


                        userInput = Console.ReadLine();
                        Console.Clear();
                        break;

                        Console.Clear();
                    
                    case "5":
                    //Add New Animal
                        Console.Clear();
                        break;

                    case "6":
                    //Generate Daily Report


                        break;
                    case "7":
                        //Demonstrate Polymorphism
                        Leo.MakeSound();
                        Ella.MakeSound();
                        Corrie.MakeSound();
                        Koda.MakeSound();
                        Manny.MakeSound();

                        break;
                    case "8":
                        //Emergency Evacuation Drill
                        EmergencyEvacuation();

                        Console.Clear();

                        break;
                    case "9":
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




        static void ProcessAnimalPolymorphism(Animal animal)
        {
            Console.WriteLine($"\nProcessing {animal.Name} ({animal.GetType().Name}):");
            animal.MakeSound();
            animal.Feed();
        }
        

       /* public void AddAnimal(Animal animal)
        {
            foreach (var habitat in Habitats)
            {
                if (habitat.CanAccommodate(animal))
                {
                    habitat.AddAnimal(animal);
                    Animals.Add(animal);
                    Console.WriteLine($"{animal.Name} Successfully added to {habitat.Name}.");
                    return;
                }

            }
            Console.WriteLine($"No suitable habitat found for {animal.Name}({animal.GetType().Name}).");
        }
       */
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
            
            Console.WriteLine($"A fire has been detected!");
            Console.WriteLine($"Leo has been evacuated!");
            Console.WriteLine($"Corrie has been evacuated!");
            Console.WriteLine($"Ella has been evacuated!");
            Console.WriteLine($"Koda has been evacuated!");
            Console.WriteLine($"Manny has been evacuated!");

        }

    }
}