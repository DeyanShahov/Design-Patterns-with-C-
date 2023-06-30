namespace Design_Patterns_with_C_.Creational_Patterns.FactoryAbstract
{
    public class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild")) return new WildAnimalFactory();
            else if (factoryType.Contains("pet")) return new PetAnimalFactory();
            else throw new ArgumentException("You need to pass either wild or pet as argument.");
        }
    }
}
