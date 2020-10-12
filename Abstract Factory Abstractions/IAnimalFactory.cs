namespace Abstract_Factory_Abstractions
{
    public interface IAnimalFactory
    {
        IAnimal GetAnimal(int animalType);
    }
}
