namespace Design_Patterns_with_C_.Creational_Patterns.Builder
{
    public class Product
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
            foreach (string part in parts) 
                Console.WriteLine(part);
        }
      
    }
}