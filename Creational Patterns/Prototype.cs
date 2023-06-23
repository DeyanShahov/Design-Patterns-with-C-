using System;

namespace Design_Patterns_with_C_.Creational_Patterns
{
    //Definition: Provides an alternative method for instantiating new object by copying or cloning an instance of an existing object.

    //Concept: Idea of this pattern is to create an object that is based on another object. This existing object acts as a template for the new object.
    internal class Prototype
    {
    }


    public abstract class BasicCar
    {
        public int basePrice = 0;
        public int onRoadPrice = 0;
        public string ModelName { get; set; }

        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(200000, 500000);
            return additionalPrice;
        }

        public abstract BasicCar Clone();

    }

    public class Nano : BasicCar
    {
        public Nano(string m) 
        {
            ModelName = m;

            basePrice = 100000;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Nano;
        }
    }

    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
            basePrice = 500000;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }


    public class CarFactory
    {
        private readonly BasicCar nano, ford;

        public CarFactory()
        {
            nano = new Nano("Green Nano");
            ford = new Ford("Ford Yellow");
        }

        public BasicCar GetNano() => nano.Clone();

        public BasicCar GetFord() => ford.Clone();
    }
}
