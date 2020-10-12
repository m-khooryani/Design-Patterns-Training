using Abstract_Factory_Abstractions;
using System;
using System.Collections.Generic;

namespace Abstract_Factory_Implementation
{
    class PetAnimalFactory : IAnimalFactory
    {
        private static Dictionary<int, Func<IAnimal>> table;

        static PetAnimalFactory()
        {
            table = new Dictionary<int, Func<IAnimal>>()
            {
                {1, () => new PetDog() },
                {2, () => new PetTiger() }
            };
        }

        public IAnimal GetAnimal(int animalType)
        {
            return table[animalType].Invoke();
        }
    }
}
