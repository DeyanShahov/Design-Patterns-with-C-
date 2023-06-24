namespace Design_Patterns_with_C_.Creational_Patterns.Builder
{
    internal interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOperations();
        Product GetVehicle();
    }
}
