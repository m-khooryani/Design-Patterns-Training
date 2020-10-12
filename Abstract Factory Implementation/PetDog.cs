using Abstract_Factory_Abstractions;

namespace Abstract_Factory_Implementation
{
    class PetDog : IAnimal
    {
        public string Speak()
        {
            return "PetDog";
        }
    }
}
