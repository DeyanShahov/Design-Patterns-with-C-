

namespace Design_Patterns_with_C_.Creational_Patterns.Builder
{
    internal class Motorcycle : IBuilder
    {
        private string brandName;
        private Product product;

        public Motorcycle(string brand)
        {
            this.brandName = brand;
            this.product = new Product();
        }

        public void AddHeadLights()
        {
            product.Add("1 HeadLights are added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void EndOperations()
        {
            product.Add($"Motorcycle model name : {this.brandName}");
            product.Add("________________");
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("2 Wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add("_______________");
        }
    }
}
