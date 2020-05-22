using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetShelterTests
    {
        Pet newPet;
        PetShelter newPetShelter;
        public PetShelterTests()
        {
            newPet = new Pet();
            newPetShelter = new PetShelter();

        }
        [Fact]
        public void Add_Pet_To_Shelter_Should_Add_Pet_To_Shelter()
        {
            newPetShelter.AddPetToShelter(newPet);

            Assert.NotNull(newPetShelter.listOfPets[0]);
        }

    }
    
}
