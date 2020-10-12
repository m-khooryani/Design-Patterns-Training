using Factory_Example_Abstractions;

namespace Factory_Example_Implementation
{
    class Tiger : IAnimal
    {
        public string Action()
        {
            return "Tiget::Action";
        }

        public string Speak()
        {
            return "Tiger::Speak";
        }
    }
}
