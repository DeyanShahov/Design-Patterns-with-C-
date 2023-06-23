using System;

namespace Design_Patterns_with_C_.Creational_Patterns
{
    // DEFINITION : Ensure a class has only one instance, and provide a global point of access to it.
    public sealed class Singleton
    {
        private static readonly Singleton instance;
        private static int totalInstances;

        private Singleton()
        {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit now from private constructor.");
        }

        static Singleton()
        {
            Console.WriteLine("-Static constructor is caled.");
            instance = new Singleton();
            totalInstances++;
            Console.WriteLine($"-Singleton instance is created. Number of instances: {totalInstances}");
            Console.WriteLine("-Exit from static constructor.");
        }

        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }

        //public static Singleton GetInstance => instance;

        public static int MyInt = 25;
    }
}
