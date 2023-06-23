using Design_Patterns_with_C_.Creational_Patterns;

namespace Design_Patterns_with_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demonstration.***\n");
            Console.WriteLine($"The value of MyInt is: {SingletonStaticConstructor.MyInt}");

            //Singleton s = new Singleton(); //error

            Console.WriteLine("Trying to get a Singleton instance, called firstInstance.");

            SingletonStaticConstructor firstInstance = SingletonStaticConstructor.GetInstance;

            Console.WriteLine("Trying to get another Singleton instance, called secondInstance.");

            SingletonStaticConstructor secondInstance = SingletonStaticConstructor.GetInstance;

            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The firstInstance and secondInstance are the same.");
            }
            else
            {
                Console.WriteLine("Different instance exist.");
            }
            Console.Read();

            //Console.WriteLine(Singleton.MyInt);
        }
    }
}