namespace Design_Patterns_with_C_.Creational_Patterns.Builder
{
    internal class Director
    {
        IBuilder builder;

        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOperations();
        }
     

    }
}
