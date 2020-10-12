using System;
using System.Collections.Generic;
using Abstract_Factory_Abstractions;

namespace Factory_Example_Implementation
{
    public class AnimalFactory : IAnimalFactory
    {
        private static Dictionary<int, Func<IAnimal>> table;

        static AnimalFactory()
        {
            table = new Dictionary<int, Func<IAnimal>>()
            {
                {1, () => new Dog() },
                {2, () => new Tiger() }
            };
        }

        public IAnimal Create(int animalType)
        {
            return table[animalType].Invoke();
        }
    }
}
