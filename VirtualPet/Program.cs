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
            List<Pet> listOfPets = petShelter.GetPetList();
            

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            newPet.CreatePet();

            petShelter.AddPetToShelter(newPet);


            bool continuePlayingWithPet = true;
            do
            {
                newPet.Tick();
                petShelter.ShowAllPetStatus();
                

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine($"1. Feed {newPet.GetName()}");
                Console.WriteLine($"2. Play with {newPet.GetName()}");
                Console.WriteLine($"3. Take {newPet.GetName()} to doctor");
                Console.WriteLine($"4. See {newPet.GetName()} hunger");
                Console.WriteLine($"5. See {newPet.GetName()} bordeom");
                Console.WriteLine($"6. See {newPet.GetName()} health");
                Console.WriteLine("7. Add another pet to shelter");
                Console.WriteLine("8. See name and status of all pets");
                Console.WriteLine("9. Feed all pets");
                Console.WriteLine("10. Take all pets to doctor");
                Console.WriteLine("11. Play with all pets");
                Console.WriteLine("12. Select specific pet");
                Console.WriteLine("13. Exit virtual pet");

                string userInput = Console.ReadLine();
                Console.Clear(); 
                switch (userInput)
                {
                    case "1":
                        {
                            newPet.Feed();
                            Console.WriteLine("You've fed your Pet");
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
                            newPet.SeeDoctor();
                            Console.WriteLine("You've taken your pet to the Doctor");
                            break;

                        }
                    case "4":
                        {
                            int currentHunger = newPet.GetHunger();
                            Console.WriteLine($"{newPet.GetName()} hunger is {currentHunger}");
                            break;
                        }
                    case "5":
                        {
                            int currentBordom = newPet.GetBoredom();
                            Console.WriteLine($"{newPet.GetName()} boredom is {currentBordom}");
                            break;
                        }
                    case "6":
                        {
                            int currentHealth = newPet.GetHealth();
                            Console.WriteLine($"{newPet.GetName()} health is {currentHealth}");
                            break;
                        }
                    case "7":
                        {
                            newPet = new Pet();
                            newPet.CreatePet();

                            petShelter.AddPetToShelter(newPet);
                            break;
                        }
                    case "8":
                        {
                            petShelter.ShowAllPetStatus();
                            break;
                        }
                    case "9":
                        {
                            petShelter.FeedAllPets();
                            Console.WriteLine("You've feed all pets");
                            break;
                        }
                    case "10":
                        {
                            petShelter.AllPetsSeeDoctor();
                            Console.WriteLine("You've taken all pets to the doc");
                            break;
                        }
                    case "11":
                        {
                            petShelter.AllPetsPlay();
                            Console.WriteLine("You've played with all pets");
                            break;
                        }
                    case "12":
                        {
                            int petLineNumber = 1;
                            foreach (Pet pet in listOfPets)
                            {
                                Console.WriteLine($"{petLineNumber}. {pet.GetName()}");
                                petLineNumber++;
                            }
                            Console.WriteLine("What pet do you want to select?");
                            int selectNewPet = Convert.ToInt32(Console.ReadLine());
                            newPet = petShelter.SelectPetFromShelter(selectNewPet - 1);
                            break;

                        }

                    case "13":
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
        
    

