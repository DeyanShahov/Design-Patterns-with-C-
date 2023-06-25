namespace Design_Patterns_with_C_.Creational_Patterns.FactorySimple
{
    internal class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The dogs says: Bow-Wow. I prefer barking.");
        }
    }
}
