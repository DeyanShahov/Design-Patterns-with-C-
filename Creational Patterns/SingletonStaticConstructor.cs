namespace Design_Patterns_with_C_.Creational_Patterns
{
    //Definition: Ensure a class has only one instance, and provide a global point of access to it.

    //Concept: It restricts the use of new and ensures that you do not have more than one instance of the class. In short, this pattern says that a class
    //  should have only one instance. You can create an instance if it is not available; otherwise, you should use an existing instance to serve your needs.

    //When should to use:
    //  • When working with a centralized system(for example a database)
    //  • When maintaining a common log file
    //  • When maintaining a thread pool in a multithreaded environment
    //  • When implementing a caching mechanism or device drivers, and so forth
    public sealed class SingletonStaticConstructor
    {
        private static readonly SingletonStaticConstructor instance;
        private static int totalInstances;

        private SingletonStaticConstructor()
        {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit now from private constructor.");
        }

        static SingletonStaticConstructor()
        {
            Console.WriteLine("-Static constructor is caled.");
            instance = new SingletonStaticConstructor();
            totalInstances++;
            Console.WriteLine($"-Singleton instance is created. Number of instances: {totalInstances}");
            Console.WriteLine("-Exit from static constructor.");
        }

        public static SingletonStaticConstructor GetInstance
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
