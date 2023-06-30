using Design_Patterns_with_C_.Structural_Patterns.Proxy_Pattern;

namespace Design_Patterns_with_C_.Structural_Patterns.Proxy2_Pattern
{
    public class Proxy2 : Subject
    {
        Subject subject;
        string[] registredUsers;
        string currentUser;

        public Proxy2(string cuurentUser)
        {
            registredUsers = new string[] { "Admin", "Rohit", "Sam" };
            this.currentUser = cuurentUser;
        }
        public override void DoSomeWork()
        {
            Console.WriteLine($"{currentUser} wants to acces into the system.");

            if ( registredUsers.Contains(currentUser))
            {
                Console.WriteLine("Welcome, {0}.", currentUser);

                if (subject == null)
                {
                    subject = new ConcreteSubject();
                };

                subject.DoSomeWork();
            }
            else
            {
                Console.WriteLine($"Sorry {currentUser}, you do not have acces into the system.");
            };                   
        }
    }
}
