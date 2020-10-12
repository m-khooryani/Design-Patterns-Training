using Factory_Example_Abstractions;

namespace Factory_Example_Implementation
{
    class Dog : IAnimal
    {
        public string Action()
        {
            return "Dog::Action";
        }

        public string Speak()
        {
            return "Dog::Speak";
        }
    }
}
