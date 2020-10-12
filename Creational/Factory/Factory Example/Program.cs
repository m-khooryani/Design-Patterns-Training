using Factory_Example_Abstractions;
using Factory_Example_Implementation;
using System;

namespace Factory_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory = new AnimalFactory();
            IAnimal animal = animalFactory.Create(1);
            Console.WriteLine(animal.Speak());
        }
    }
}
