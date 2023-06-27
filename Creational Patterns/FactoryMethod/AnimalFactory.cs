using Design_Patterns_with_C_.Creational_Patterns.FactorySimple;

namespace Design_Patterns_with_C_.Creational_Patterns.FactoryMethod
{
    public abstract class AnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("AnimalDactory.MakeAnimal() - You cannot ignore parent rules.");
            IAnimal animal = CreateAnimal();
            animal.AboutMe();
            return animal;
        }
        public abstract IAnimal CreateAnimal();
    }
}
