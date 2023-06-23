using System;

namespace Design_Patterns_with_C_.Creational_Patterns
{
    public sealed class SingletonDoubleCheckedLock
    {
        private static SingletonDoubleCheckedLock instance;
        private static readonly object lockObject = new object();

        private SingletonDoubleCheckedLock() { }

        public static SingletonDoubleCheckedLock GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleCheckedLock();
                        }
                    }
                }

                return instance;
            }
        }

        public void SomeMethod()
        {
            Console.WriteLine("Something here ...");
        }
    }
}
