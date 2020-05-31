using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
    {   
        public int BatteryLife { get; set; }
        public int OilLevel { get; set; }

        public RoboticPet()
        {
            BatteryLife = 100;
            OilLevel = 60;

        }
        public int GetBatteryLife()
        {
            return BatteryLife;
        }
        public int GetOilLevel()
        {
            return OilLevel;
        }
        public override void Play()
        {
            OilLevel -= 20;
            BatteryLife -= 20;
        }
        public override void Feed()
        {
            Console.WriteLine("You don't need to feed a Robo pet");
        }
        public override void Tick()
        {
            BatteryLife -= 5;
            OilLevel -= 5;
        }
        public override void CareForPet()
        {
            Console.WriteLine($"You've taken {Name} for maintenance");
            BatteryLife += 50;
            OilLevel += 50;
        }
        public override void CreatePet()
        {
            Console.WriteLine("\nWhat would you like to name it?");
            string petName = Console.ReadLine();

            SetName(petName);

            Console.WriteLine("\nWhat type of animal do you want? Make sure you type *Robo* in front of your animal species");
            string petSpecies = Console.ReadLine();

            SetSpecies(petSpecies);
        }
    
        
        
    }
}

    
