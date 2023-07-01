namespace Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern
{
    internal class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 5000;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            PaintHome();
        }

        private void PaintHome()
        {
            Console.WriteLine($"--Painting done. Pay additional ${AdditionalPrice} for it.");
        }
    }
}
