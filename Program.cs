using Design_Patterns_with_C_.Creational_Patterns;
using System.Diagnostics;

namespace Design_Patterns_with_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CallSingletonPatterns();
            //CallPrototypePattern();
            Call2PrototypePattern();
        }

        private static void Call2PrototypePattern()
        {
            Console.WriteLine("***Prototype Pattern Demo2.***\n");
            CarFactory carFactory = new CarFactory();

            // Get a Nano
            BasicCar basicCar = carFactory.GetNano();
            //Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
           SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");
            // Get a Ford now
            basicCar = carFactory.GetFord();
            // Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
           SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

            Console.ReadLine();
        }

        private static void CallPrototypePattern()
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            BasicCar nano = new Nano("Green Nano");
            BasicCar ford = new Ford("Ford Yellow");
            BasicCar basicCar;

            //Nano
            basicCar = nano.Clone();
            //Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and its price is Rs. {basicCar.onRoadPrice}");

            //Ford
            basicCar = ford.Clone();
            //Working  on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and its price is Rs. {basicCar.onRoadPrice}");

            Console.ReadLine();
        }

        private static void CallSingletonPatterns()
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

            Console.WriteLine();

            SingletonDoubleCheckedLock thirdInstance = SingletonDoubleCheckedLock.GetInstance;
            SingletonDoubleCheckedLock fourthInstance = SingletonDoubleCheckedLock.GetInstance;

            if (thirdInstance.Equals(fourthInstance)) Console.WriteLine("The thirdInstance and fourthInstance are the same.");
            else Console.WriteLine("Different instance exist.");
            Console.Read();

            //Console.WriteLine(Singleton.MyInt);
        }
    }
}