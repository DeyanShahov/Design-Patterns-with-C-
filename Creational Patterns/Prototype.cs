using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Design_Patterns_with_C_.Creational_Patterns
{
    //Definition: Provides an alternative method for instantiating new object by copying or cloning an instance of an existing object.

    //Concept: Idea of this pattern is to create an object that is based on another object. This existing object acts as a template for the new object.

    //Advantages:
    //•You do not want to modify the existing object and experiment on that.
    //• You can include or discard products at runtime.
    //• In some contexts, you can create new instances at a cheaper cost.
    //• You can focus on the key activities rather than focusing on complicated instance creation processes.For example, once you ignore
    //      the complex object creation processes, you can simply start with cloning or copying objects and implementing the remaining parts.
    //• You want to get a feel for the new object’s behavior before you fully implement it.

    //Challenges:
    //• Each subclass needs to implement the cloning or copying mechanism.
    //• Implementing the cloning mechanism can be challenging if the objects under consideration do not support copying or 
    //    if there are circular references.
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
        //Drawback: Initialized the cars inside the constructor. Always creates instances of both car types when the class is initialized.

        private readonly BasicCar nano, ford;

        public CarFactory()
        {
            nano = new Nano("Green Nano");
            ford = new Ford("Ford Yellow");
        }

        public BasicCar GetNano() => nano.Clone();

        public BasicCar GetFord() => ford.Clone();
    }

    public class CarFactory2
    {
        private BasicCar nano, ford;

        public BasicCar GetNano() => nano != null ? nano.Clone() : new Nano("Green Nano");

        public BasicCar GetFord()
        {
            if (ford != null) return ford.Clone();
            else return new Ford("Ford Yellow");          
        }
    }
}
