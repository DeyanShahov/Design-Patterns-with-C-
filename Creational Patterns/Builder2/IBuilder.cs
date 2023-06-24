namespace Design_Patterns_with_C_.Creational_Patterns.Builder2
{
    internal interface IBuilder
    {
        IBuilder StartUpOperations(string optionalStartUpMeddage = " Making a car for you.");
        IBuilder BuildBody(string optionalBodyType = "Steel");
        IBuilder InsertWheels(int optionalNoOfWheels = 4);
        IBuilder AddHeadLights(int optionalNoOfHeadLights = 2);
        IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.");
        Product ConstructCar();
    }
}
