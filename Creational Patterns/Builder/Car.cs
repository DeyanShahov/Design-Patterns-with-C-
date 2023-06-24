namespace Design_Patterns_with_C_.Creational_Patterns.Builder
{
    internal class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void AddHeadLights()
        {
            product.Add("2 Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }

        public void EndOperations()
        {
            product.Add("--------------");
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add("------------");
            product.Add($"Car model name : {this.brandName}");
        }
    }
}
