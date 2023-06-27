using Design_Patterns_with_C_.Creational_Patterns.FactorySimple;

namespace Design_Patterns_with_C_.Creational_Patterns.FactoryMethod
{
    internal class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }
}
