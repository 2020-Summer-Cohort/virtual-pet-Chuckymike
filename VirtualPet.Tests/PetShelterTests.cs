using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetShelterTests
    {
        Pet newPet;
        Pet newPet2;
        PetShelter newPetShelter;
        public PetShelterTests()
        {
            newPet = new Pet();
            newPet2 = new Pet();
            newPetShelter = new PetShelter();

        }
        [Fact]
        public void Add_Pet_To_Shelter_Should_Add_Pet_To_Shelter()
        {
            newPetShelter.AddPetToShelter(newPet);

            Assert.NotNull(newPetShelter.listOfPets[0]);
        }
        [Fact]
        public void Get_Pet_List_Should_Return_List_Of_Pets()
        {

            newPetShelter.AddPetToShelter(newPet);
            newPetShelter.AddPetToShelter(newPet2);
            newPetShelter.GetPetList();

            Assert.IsType<List<Pet>>(newPetShelter.listOfPets);

        }

    }
    
}
