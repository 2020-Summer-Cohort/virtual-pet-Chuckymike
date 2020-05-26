using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public List<Pet> listOfPets = new List<Pet>();

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
                pet.SeeDoctor();
            }
        }
        public void AllPetsPlay()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Play();
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
                Console.WriteLine($"{pet.GetName()}, Health {pet.GetHealth()}, Hunger {pet.GetHunger()}, Boredom {pet.GetBoredom()}");
            }
        }
        public void AdoptPetFromShelter(Pet adoptedPet)
        {
             listOfPets.Remove(adoptedPet);
        }
    }

}
