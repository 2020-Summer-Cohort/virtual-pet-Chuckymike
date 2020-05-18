using System;
using System.Text;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet();
            

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("\nWhat would you like to name it?");
            string petName = Console.ReadLine();

            bool continuePlayingWithPet = true;
            do
            {

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine($"1. Feed {petName}");
                Console.WriteLine($"2. Play with {petName}");
                Console.WriteLine($"3. Take {petName} to doctor");
                Console.WriteLine($"4. See {petName} hunger");
                Console.WriteLine($"5. See {petName} bordeom");
                Console.WriteLine($"6. See {petName} health");
                Console.WriteLine("7. Exit virtual pet");

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
                            Console.WriteLine($"{petName} hunger is {currentHunger}");
                            break;
                        }
                    case "5":
                        {
                            int currentBordom = newPet.GetBoredom();
                            Console.WriteLine($"{petName} boredom is {currentBordom}");
                            break;
                        }
                    case "6":
                        {
                            int currentHealth = newPet.GetHealth();
                            Console.WriteLine($"{petName} health is {currentHealth}");
                            break;
                        }
                    case "7":
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
        
    

