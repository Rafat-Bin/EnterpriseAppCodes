using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Animals
{
    public class Bird
    {
        private string _name;
        private int _age;
        private string _species;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 20)
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid value for Age");
                _age = value;
            }
        }

        public string Species
        {
            get => _species;
            private set => _species = value;
        }

        public Bird(string name, int age, string species)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Species: {Species}";
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name} chirps excitedly.");
        }
    }
}
