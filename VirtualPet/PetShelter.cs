using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public List<Pet> listOfPets = new List<Pet>();
        //public List<RoboticPet> listOfPets = new List<RoboticPet>();

        public void AddPetToShelter(Pet pet)
        {
            listOfPets.Add(pet);
            Console.WriteLine("You've added a pet to the shelter");
        }
        
        public List<Pet> GetPetList()
        {
            return listOfPets;
        }
        public void FeedAllPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Feed();
            }
            
        }
        public void AllPetsSeeDoctor()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.CareForPet();
            }
        }
        public void AllPetsPlay()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Play();
            }
        }
        public void AllPetsTick()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Tick();
            }
        }
        public Pet SelectPetFromShelter(int petIndex)
        {
            return listOfPets[petIndex]; 
        }
        public void ShowAllPetStatus()
        {
            foreach(Pet pet in listOfPets)
            {
                if (pet is RoboticPet) 
                {
                    RoboticPet roboticPet = (RoboticPet)pet;
                    Console.WriteLine($"{roboticPet.Name}|| {roboticPet.Species}|| Oil Level {roboticPet.GetOilLevel()}|| Battery Life {roboticPet.GetBatteryLife()}");
                }
                else Console.WriteLine($"{pet.GetName()}|| {pet.GetSpecies()}|| Health {pet.GetHealth()}|| Hunger {pet.GetHunger()}|| Boredom {pet.GetBoredom()}");
            }
            
            
        }
        public void AdoptPetFromShelter(Pet adoptedPet)
        {
             listOfPets.Remove(adoptedPet);
        }
        public void ShowPetNames()
        {
            int petLineNumber = 1;
            foreach (Pet pet in listOfPets)
            {
                Console.WriteLine($"{petLineNumber}. {pet.GetName()} the {pet.GetSpecies()}");
                petLineNumber++;
            }
        }
    }

}
