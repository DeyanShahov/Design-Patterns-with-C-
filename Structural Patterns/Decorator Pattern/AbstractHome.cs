namespace Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern
{
    abstract class AbstractHome
    {
        public double AdditionalPrice { get; set; }
        public abstract void MakeHome();

    }
}
