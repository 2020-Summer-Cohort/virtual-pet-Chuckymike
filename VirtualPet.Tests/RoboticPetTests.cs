using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticPetTests
    {
        private RoboticPet roboticPetTests;
        public RoboticPetTests()
        {
            roboticPetTests = new RoboticPet();
        }
        [Fact]
        public void RoboPet_Should_Have_Battery_Life()
        {
            Assert.NotNull(roboticPetTests.BatteryLife);
        }
        [Fact]
        public void GetBatteryLife_Should_Return_Initial_Battery_Life_Of_40()
        {
            
            int roboTestPetBatteryLife = roboticPetTests.GetBatteryLife();

            Assert.Equal(40, roboTestPetBatteryLife);
        }
        [Fact]
        public void RoboPet_Should_Have_Oil_Level()
        {
            Assert.NotNull(roboticPetTests.OilLevel);
        }

        [Fact]
        public void GetOilLevel_Should_Return_Initial_Oil_Level_Of_50()
        {
            int roboTestPetOilLevel = roboticPetTests.GetOilLevel();

            Assert.Equal(50, roboTestPetOilLevel);
        }
        [Fact]
        public void Play_Should_Decrease_Oil_Level_By_20()
        {
            roboticPetTests.Play();

            Assert.Equal(30, roboticPetTests.GetOilLevel());
        }

        [Fact]
        public void Play_Should_Decrease_Battery_Life_By_20()
        {
            roboticPetTests.Play();

            Assert.Equal(20, roboticPetTests.GetBatteryLife());
        }
        [Fact]
        public void CareForPet_Should_Increase_BatteryLife_50()
        {
            roboticPetTests.CareForPet();

            Assert.Equal(90, roboticPetTests.GetBatteryLife());
        }
        [Fact]
        public void CareForPet_Should_Increase_OilLevel_50()
        {
            roboticPetTests.CareForPet();

            Assert.Equal(100, roboticPetTests.GetOilLevel());
        }
        [Fact]
        public void Tick_Should_Decrease_Battery_Life_By_5()
        {
            roboticPetTests.Tick();

            Assert.Equal(35, roboticPetTests.GetBatteryLife());
        }

        [Fact]
        public void Tick_Should_Decrease_Oil_Level_By_5()
        {
            roboticPetTests.Tick();

            Assert.Equal(45, roboticPetTests.GetOilLevel());
        }


    }
}
