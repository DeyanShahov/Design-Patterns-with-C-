namespace Design_Patterns_with_C_.Structural_Patterns.Adapter_Pattern
{
    internal class RectangleAdapter : IRectangle
    {
        ITriangle triangle;

        public RectangleAdapter(ITriangle triangle)
        {
            this.triangle = triangle;
        }
        public void AboutMe()
        {
            triangle.AboutTriangle();
        }

        public double CalculateArea()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
