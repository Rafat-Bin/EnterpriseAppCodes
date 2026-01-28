using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Animals
{
    public class Cat
    {
        private string _name;
        private int _age;
        private string _breed;

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

        public string Breed
        {
            get => _breed;
            private set => _breed = value;
        }

        public Cat(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Breed: {Breed}";
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name} purrs quietly.");
        }
    }
}
