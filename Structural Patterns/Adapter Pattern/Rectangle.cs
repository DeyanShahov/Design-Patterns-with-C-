namespace Design_Patterns_with_C_.Structural_Patterns.Adapter_Pattern
{
    internal class Rectangle : IRectangle
    {
        double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
       
        public void AboutMe()
        {
            Console.WriteLine("I am a Rectangle");
        }

        public double CalculateArea()
        {
            return length * width;
        }
    }
}
