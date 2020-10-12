namespace Factory_Example_Abstractions
{
    public interface IAnimalFactory
    {
        IAnimal Create(int animalType);
    }
}
