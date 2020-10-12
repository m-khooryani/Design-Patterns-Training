namespace Factory_Example_Abstractions
{
    interface IAnimalFactory
    {
        IAnimal Create(int animalType);
    }
}
