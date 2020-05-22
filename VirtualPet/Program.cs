﻿using System;
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
            

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            newPet.CreatePet();

            petShelter.AddPetToShelter(newPet);


            bool continuePlayingWithPet = true;
            do
            {
                newPet.Tick();

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine($"1. Feed {newPet.GetName()}");
                Console.WriteLine($"2. Play with {newPet.GetName()}");
                Console.WriteLine($"3. Take {newPet.GetName()} to doctor");
                Console.WriteLine($"4. See {newPet.GetName()} hunger");
                Console.WriteLine($"5. See {newPet.GetName()} bordeom");
                Console.WriteLine($"6. See {newPet.GetName()} health");
                Console.WriteLine("7. Add another pet to shelter");
                Console.WriteLine("8. See name and status of all pets");
                Console.WriteLine("9. Exit virtual pet");

                string userInput = Console.ReadLine();
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
                            List<Pet> listOfPets = petShelter.GetPetList();
                            foreach (Pet pet in listOfPets)
                            {
                                Console.WriteLine($"{pet.GetName()}, Health {pet.GetHealth()}, Hunger {pet.GetHunger()}, Boredom {pet.GetBoredom()}");
                            }   
                            break;
                        }
                    case "9":
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
        
    

