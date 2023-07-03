namespace Design_Patterns_with_C_.Structural_Patterns.Adapter_Pattern
{
    internal class Triangle : ITriangle
    {
        double baseLength;
        double hight;

        public Triangle(double length, double height)
        {
            this.baseLength = length;
            this.hight = height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("I am a Triangle");
        }

        public double CalculateAreaOfTriangle()
        {
            return 0.5 * baseLength * hight;
        }
    }
}
