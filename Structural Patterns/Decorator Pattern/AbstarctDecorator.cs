namespace Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern
{
    abstract class AbstractDecorator : AbstractHome
    {
        protected AbstractHome home;

        public AbstractDecorator(AbstractHome home)
        {
            this.home = home;
            this.AdditionalPrice = 0;
        }

        public override void MakeHome()
        {
            home.MakeHome();
        }
    }
}
