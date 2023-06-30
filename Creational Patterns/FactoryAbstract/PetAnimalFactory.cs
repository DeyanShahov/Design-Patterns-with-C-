namespace Design_Patterns_with_C_.Creational_Patterns.FactoryAbstract
{
    public class PetAnimalFactory : IAnimalFactory
    {
        public IDog GetDog() => new PetDog();

        public ITiger GetTiger() => new PetTiger();
    }
}
