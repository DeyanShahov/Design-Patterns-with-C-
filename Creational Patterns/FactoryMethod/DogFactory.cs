using Design_Patterns_with_C_.Creational_Patterns.FactorySimple;

namespace Design_Patterns_with_C_.Creational_Patterns.FactoryMethod
{
    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Dog();
    }
}
