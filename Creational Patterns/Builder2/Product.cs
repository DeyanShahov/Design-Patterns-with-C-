namespace Design_Patterns_with_C_.Creational_Patterns.Builder2
{
    sealed class Product
    {
        private List<string> parts;

        public Product()
        {
           parts = new List<string>();
        }

        public void Add(string part) => parts.Add(part);

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below : ");
            foreach (var part in parts) Console.WriteLine(part);
        }
    }
}
