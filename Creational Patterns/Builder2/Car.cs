namespace Design_Patterns_with_C_.Creational_Patterns.Builder2
{
    internal class Car : IBuilder
    {
        Product product;
        private string brandName;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public IBuilder AddHeadLights(int optionalNoOfHeadLights = 2)
        {
            product.Add(($"Headlights:{optionalNoOfHeadLights.ToString()}"));
            return this;
        }

        public IBuilder BuildBody(string optionalBodyType = "Steel")
        {
            product.Add($"Body type: {optionalBodyType}");
            return this;
        }

        public Product ConstructCar()
        {
            return product;
        }

        public IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.")
        {
            product.Add(optionalEndMessage);
            return this;
        }

        public IBuilder InsertWheels(int optionalNoOfWheels = 4)
        {
            product.Add($"Wheels:{optionalNoOfWheels.ToString()}");
            return this;
        }

        public IBuilder StartUpOperations(string optionalStringMessage = "Making a car for you.")
        {
            product.Add(optionalStringMessage);
            product.Add($"Car model name : {this.brandName}");
            return this;
        }
    }
}
