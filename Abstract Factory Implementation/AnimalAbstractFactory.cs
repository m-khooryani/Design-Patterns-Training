using Abstract_Factory_Abstractions;
using System;
using System.Collections.Generic;

namespace Abstract_Factory_Implementation
{
    public class AnimalAbstractFactory : IAnimalAbstractFactory
    {
        private static Dictionary<int, Func<IAnimalFactory>> table;

        static AnimalAbstractFactory()
        {
            table = new Dictionary<int, Func<IAnimalFactory>>()
            {
                {1, () => new PetAnimalFactory() },
                {2, () => new WildAnimalFactory() },
            };
        }

        public IAnimal GetAnimal(int animalType, int petWildType)
        {
            IAnimalFactory animalFactory = table[petWildType].Invoke();
            return animalFactory.GetAnimal(animalType);
        }
    }
}
