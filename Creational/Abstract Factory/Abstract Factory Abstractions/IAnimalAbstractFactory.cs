namespace Abstract_Factory_Abstractions
{
    public interface IAnimalAbstractFactory
    {
        IAnimal GetAnimal(int animalType, int petWildType);
    }
}
