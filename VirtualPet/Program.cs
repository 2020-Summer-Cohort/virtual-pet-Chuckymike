using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet();
            PetShelter petShelter = new PetShelter();
            RoboticPet roboticPet = new RoboticPet();
            List<Pet> listOfPets = petShelter.GetPetList();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.ResetColor();
            newPet.CreatePet();

            petShelter.AddPetToShelter(newPet);


            bool continuePlayingWithPet = true;
            do
            {
                petShelter.AllPetsTick();
                petShelter.ShowAllPetStatus();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWhat would you like to do?");
                Console.ResetColor();
                Console.WriteLine($"1. Feed {newPet.GetName()}");
                Console.WriteLine($"2. Play with {newPet.GetName()}");
                Console.WriteLine($"3. Take {newPet.GetName()} to doctor or for maintenance");
                Console.WriteLine("4. Add pet");
                Console.WriteLine("5. Add RoboPet");
                Console.WriteLine("6. Feed all pets");
                Console.WriteLine("7. Take all pets to doctor or for maintenance");
                Console.WriteLine("8. Play with all pets");
                Console.WriteLine("9. Select specific pet");
                Console.WriteLine("10. Adopt pet");
                Console.WriteLine("11. Exit virtual pet");

                string userInput = Console.ReadLine();
                Console.Clear(); 
                switch (userInput)
                {
                    case "1":
                        {
                            newPet.Feed();
                            break;

                        }
                    case "2":
                        {
                            newPet.Play();
                            Console.WriteLine("You've played with your Pet");
                            break;
                        }
                    case "3":
                        {
                            newPet.CareForPet();
                            break;

                        }
                    case "4":
                        {
                            newPet = new Pet();
                            newPet.CreatePet();

                            petShelter.AddPetToShelter(newPet);
                            break;
                        }
                    case "5":
                        {
                            roboticPet = new RoboticPet();
                            roboticPet.CreatePet();

                            petShelter.AddPetToShelter(roboticPet);
                            break;
                        }
                    case "6":
                        {
                            petShelter.FeedAllPets();
                            break;
                        }
                    case "7":
                        {
                            petShelter.AllPetsSeeDoctor();
                            break;
                        }
                    case "8":
                        {
                            petShelter.AllPetsPlay();
                            break;
                        }
                    case "9":
                        {
                            petShelter.ShowPetNames();
                            Console.WriteLine("What pet do you want to select?");
                            int selectNewPet = Convert.ToInt32(Console.ReadLine());
                            newPet = petShelter.SelectPetFromShelter(selectNewPet - 1);
                            break;

                        }
                    case "10":
                        {
                            petShelter.ShowPetNames();
                            Console.WriteLine("What pet do you want to adopt?");
                            int selectNewPet = Convert.ToInt32(Console.ReadLine());
                            newPet = petShelter.SelectPetFromShelter(selectNewPet - 1);
                            petShelter.AdoptPetFromShelter(newPet);
                            break;
                        }

                    case "11":
                        {
                            Console.WriteLine("Thanks for playing Virtual Pet");
                            continuePlayingWithPet = false;
                            break;
                        }
                }

            } while (continuePlayingWithPet) ;
            
        } 
    }

}
        
    

