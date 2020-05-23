using System;
using System.Collections.Generic;
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
    }

}
