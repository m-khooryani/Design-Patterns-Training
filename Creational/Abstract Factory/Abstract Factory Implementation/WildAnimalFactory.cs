using Abstract_Factory_Abstractions;
using System;
using System.Collections.Generic;

namespace Abstract_Factory_Implementation
{
    class WildAnimalFactory : IAnimalFactory
    {
        private static Dictionary<int, Func<IAnimal>> table;

        static WildAnimalFactory()
        {
            table = new Dictionary<int, Func<IAnimal>>()
            {
                {1, () => new WildDog() },
                {2, () => new WildTiger() }
            };
        }

        public IAnimal GetAnimal(int animalType)
        {
            return table[animalType].Invoke();
        }
    }
}
