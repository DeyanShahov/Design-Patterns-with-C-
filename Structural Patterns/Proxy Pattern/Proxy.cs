namespace Design_Patterns_with_C_.Structural_Patterns.Proxy_Pattern
{
    public class Proxy : Subject
    {
        Subject subject;
        public override void DoSomeWork()
        {
            Console.WriteLine("Welcome, my client.");

            if(subject == null) subject = new ConcreteSubject();

            subject.DoSomeWork();
        }
    }
}
