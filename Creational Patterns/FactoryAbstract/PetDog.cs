namespace Design_Patterns_with_C_.Creational_Patterns.FactoryAbstract
{
    public class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet dog says: Bow-Wow. I prefer to stay at home.");
        }
    }
}
