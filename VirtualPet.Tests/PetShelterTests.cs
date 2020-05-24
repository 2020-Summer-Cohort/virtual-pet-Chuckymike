using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetShelterTests
    {
        Pet testPet;
        Pet testPet2;
        PetShelter testPetShelter;
        public PetShelterTests()
        {
            testPet = new Pet();
            testPet2 = new Pet();
            testPetShelter = new PetShelter();

        }
        [Fact]
        public void Add_Pet_To_Shelter_Should_Add_Pet_To_Shelter()
        {
            testPetShelter.AddPetToShelter(testPet);

            Assert.NotNull(testPetShelter.listOfPets[0]);
        }
        [Fact]
        public void Get_Pet_List_Should_Return_List_Of_Pets()
        {

            
            testPetShelter.GetPetList();

            Assert.IsType<List<Pet>>(testPetShelter.listOfPets);

        }
        [Fact]
        public void Feed_All_Pets_Should_Decrease_Hunger_By_40()
        {
            testPetShelter.AddPetToShelter(testPet);
            testPetShelter.AddPetToShelter(testPet2);
            testPetShelter.FeedAllPets();

            Assert.Equal(10, testPet.Hunger);
            Assert.Equal(10, testPet2.Hunger);
        }
        [Fact]
        public void SeeDoctor_All_Pets_Health_Should_Increase_By_30()
        {
            testPetShelter.AddPetToShelter(testPet);
            testPetShelter.AddPetToShelter(testPet2);
            testPetShelter.AllPetsSeeDoctor();

            Assert.Equal(60, testPet.Health);
            Assert.Equal(60, testPet2.Health);

        }
        [Fact]
        public void PlayWithAll_Pets_Should_Increase_Hunger_By_10()
        {
            testPetShelter.AddPetToShelter(testPet);
            testPetShelter.AddPetToShelter(testPet2);
            testPetShelter.AllPetsPlay();

            Assert.Equal(60, testPet.Hunger);
            Assert.Equal(60, testPet2.Hunger);
        }
        [Fact]
        public void PlayWithAll_Pets_Should_Decrease_Boredom_By_20()
        {
            testPetShelter.AddPetToShelter(testPet);
            testPetShelter.AddPetToShelter(testPet2);
            testPetShelter.AllPetsPlay();

            Assert.Equal(40, testPet.Boredom);
            Assert.Equal(40, testPet2.Boredom);
        }
        [Fact]
        public void PlayWithAll_Pets_Should_Increase_Health_By_10()
        {
            testPetShelter.AddPetToShelter(testPet);
            testPetShelter.AddPetToShelter(testPet2);
            testPetShelter.AllPetsPlay();

            Assert.Equal(40, testPet.GetHealth());//GetHealth and Health are same
            Assert.Equal(40, testPet2.GetHealth());
        }
        [Fact]
        public void SelectPet_Should_Allow_User_To_Select_Pet()
        {
            testPetShelter.SelectPetFromShelter(testPet);
            testPetShelter.SelectPetFromShelter(testPet2);

            Assert.NotNull(testPetShelter.listOfPets);

        }

    }
    
}
