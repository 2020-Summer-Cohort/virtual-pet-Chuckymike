using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : PetShelter
    {
        public new List<RoboticPet> listOfPets = new List<RoboticPet>();

        public new string Name { get; set; }
        public new string Species { get; set; }
        public int BatteryLife { get; set; }
        public int OilLevel { get; set; }

        public RoboticPet()
        {
            BatteryLife = 100;
            OilLevel = 60;

        }
        public new void SetName(string name)
        {
            Name = name;
        }
        public new void SetSpecies(string species)
        {
            Species = species;
        }
        public int GetBatteryLife()
        {
            return BatteryLife;
        }
        public int GetOilLevel()
        {
            return OilLevel;
        }
        public new void Play()
        {
            OilLevel -= 20;
            BatteryLife -= 20;

        }
        public new void Tick()
        {
            BatteryLife -= 5;
            OilLevel -= 5;
        }
        public void TakeForMaintenance()
        {
            BatteryLife += 50;
            OilLevel += 50;
        }
        public void SellRoboPet(Pet adoptedPet)
        {
            base.listOfPets.Remove(adoptedPet);
        }
        public new void CreatePet()
        {
            Console.WriteLine("\nWhat would you like to name it?");
            string petName = Console.ReadLine();

            SetName(petName);

            Console.WriteLine("\nWhat type of animal do you want? Make sure you type *Robo* in front of your animal species");
            string petSpecies = Console.ReadLine();

            SetSpecies(petSpecies);
        }
        public void ShowAllPetStatus(RoboticPet robotic)
        {
            foreach (RoboticPet roboticPet in base.listOfPets)
            {
                Console.WriteLine($"{robotic.Name}|| {robotic.Species}|| Oil Level {robotic.GetOilLevel()}|| Battery Life {robotic.GetBatteryLife()}");
            }
        }
        
        
    }
}

    
