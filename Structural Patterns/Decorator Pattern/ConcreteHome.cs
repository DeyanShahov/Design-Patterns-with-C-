﻿namespace Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern
{
    internal class ConcreteHome : AbstractHome
    {
        public ConcreteHome()
        {
            AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            Console.WriteLine($"Original House is constructed. Price for this 10 000$");
        }
    }
}
