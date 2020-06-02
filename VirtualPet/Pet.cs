using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        Random random = new Random();

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

        public virtual void Feed()
        {
            Console.WriteLine($"You've fed {Name}");
            Hunger -= 40;
            if(Hunger <= 0)
            {
                Hunger = 0;
            }
        }

        public virtual void CareForPet()
        {
            Console.WriteLine($"You took {Name} to the vet");
            Health += 30;
            if (Health >= 100)
            {
                Health = 100;
            }
        }

        public virtual void Play()
        {
             Hunger += 10;
             Boredom -= 20;
             Health += 10;
            if(Hunger >= 100)
            {
                Hunger = 100;
            }
            if (Boredom <= 0)
            {
                Boredom = 0;
            }
            if (Health >= 100)
            {
                Health = 100;
            }
            
        }

        public virtual void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
            if (Hunger >= 100)
            {
                Hunger = 100;
            }
            if (Boredom >= 100)
            {
                Boredom = 100;
            }
            if(Health <= 0)
            {
                Health = 0;
            }
        }
        public virtual void CreatePet()
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
