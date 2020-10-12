using Abstract_Factory_Abstractions;
using Abstract_Factory_Implementation;
using System;

namespace Abstract_Factory_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalAbstractFactory animalFactory = new AnimalAbstractFactory();
            IAnimal animal = animalFactory.GetAnimal(2, 2);
            Console.WriteLine(animal.Speak());
        }
    }
}
