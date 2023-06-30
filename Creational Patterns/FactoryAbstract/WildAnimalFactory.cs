namespace Design_Patterns_with_C_.Creational_Patterns.FactoryAbstract
{
    public class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog() => new WIldDog();


        public ITiger GetTiger() => new WildTiger();
    }
}
