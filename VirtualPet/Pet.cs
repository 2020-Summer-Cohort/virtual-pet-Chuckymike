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

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSpecies(string Cat)
        {
            Species = Cat;
        }

        public string GetName()
        {
            return Name;

        }

    }
}
