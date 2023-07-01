namespace Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern
{
    internal class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 2500;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine($"-Additional Floor added. Pay additional {AdditionalPrice}$ for it.");
        }
    }
}
