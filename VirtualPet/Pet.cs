using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set;}
        public int Boredom { get; set;}
        public int Health { get; set; }

        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
            Name = "Chloe";

        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public int GetHunger()
        {
            return Hunger;
        }
        public string GetSpecies() 
        {
            return Species;   
        }


        public string GetName()
        {
            return Name;

        }

        public int GetBoredom()
        {
            return Boredom;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;    
        }

        public void SeeDoctor()
        {

            Health += 30;
        }

        public void Play()
        {
             Hunger += 10;
             Boredom -= 20;
             Health += 10;

            
        }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
        public void CreatePet()
        {
            Console.WriteLine("\nWhat would you like to name it?");
            string petName = Console.ReadLine();

            SetName(petName);

            Console.WriteLine("What type of animal do you want?");
            string petSpecies = Console.ReadLine();

            SetSpecies(petSpecies);
        }
    }
}
