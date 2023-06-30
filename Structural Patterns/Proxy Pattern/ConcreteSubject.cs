namespace Design_Patterns_with_C_.Structural_Patterns.Proxy_Pattern
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Ive processed you request.");
        }
    }
}
