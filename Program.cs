using Design_Patterns_with_C_.Creational_Patterns;
using Design_Patterns_with_C_.Creational_Patterns.Builder;
using Design_Patterns_with_C_.Creational_Patterns.Builder2;
using Design_Patterns_with_C_.Creational_Patterns.FactoryAbstract;
using Design_Patterns_with_C_.Creational_Patterns.FactoryMethod;
using Design_Patterns_with_C_.Creational_Patterns.FactorySimple;
using Design_Patterns_with_C_.Structural_Patterns.Adapter_Pattern;
using Design_Patterns_with_C_.Structural_Patterns.Decorator_Pattern;
using Design_Patterns_with_C_.Structural_Patterns.Proxy_Pattern;
using Design_Patterns_with_C_.Structural_Patterns.Proxy2_Pattern;
using Car = Design_Patterns_with_C_.Creational_Patterns.Builder2.Car;
using IBuilder = Design_Patterns_with_C_.Creational_Patterns.Builder.IBuilder;
using Product = Design_Patterns_with_C_.Creational_Patterns.Builder.Product;

namespace Design_Patterns_with_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

            //CallSingletonPatterns();
            //CallPrototypePattern();
            //Call2PrototypePattern();
            //CallBuilderPattern();
            //CallBuilderPattern2();
            //CallFactorySimple();
            //CallFactoryMethod();
            //CallFactoryAbstract();

            #endregion

            #region Structural Patterns

            //CallProxyPattern();
            //CallProxy2Pattern();
            //CallDecoratorPattern();

            Console.WriteLine("***Adapter Pattern Demo***\n");
            IRectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine("For initial verification purposes, printing the areas of both shapes.");
           
            Console.WriteLine("Rectangle area is:{0} Square unit",
            rectangle.CalculateArea());
            ITriangle triangle = new Triangle(20, 10);
            Console.WriteLine("Triangle area is:{0} Square unit", triangle.
            CalculateAreaOfTriangle());
            Console.WriteLine("\nNow using the adapter.");
            IRectangle adapter = new RectangleAdapter(triangle);
            Console.Write("True fact : ");
            adapter.AboutMe();
            Console.WriteLine($" and my area is : {adapter.CalculateArea()} square unit.");
            // Alternative way:
            Console.WriteLine("\nUsing the adapter in a different way now.");
            // Passing a Triangle instead of a Rectangle
            Console.WriteLine($"Area of the triangle using the adapter is :{ GetDetails(adapter)} square unit.");
            Console.ReadLine();

            static double GetDetails(IRectangle rectangle)
            {
                rectangle.AboutMe();
                return rectangle.CalculateArea();
            }

            #endregion


        }

        private static void CallDecoratorPattern()
        {
            Console.WriteLine("***Decorator pattern Demo***\n");

            #region Scenario-1
            Console.WriteLine("\n**Scenario-1: ");
            Console.WriteLine("**Building home. Adding floor and then painting it.**");

            AbstractHome home = new ConcreteHome();
            Console.WriteLine("Current build breakups are as follows: ");
            home.MakeHome();

            //Applying a decorator
            //Adding a floor
            home = new FloorDecorator(home);
            Console.WriteLine("\nFloor added. Current bill breakups are as follows: ");
            home.MakeHome();

            //Working on top of the previous decorator
            //Painting the home
            home = new PaintDecorator(home);
            Console.WriteLine("\nPaint applied. Current bill breakups are as follows: ");
            home.MakeHome();
            #endregion

            #region Scenario-2
            Console.WriteLine("\n**Scenario-2:");
            Console.WriteLine("**Building home,painting it and then adding two additional floors on top of it.**");
            // Fresh start once again.
            home = new ConcreteHome();
            Console.WriteLine("\nGoing back to original home.Current bill breakups are as follows:");

            home.MakeHome();
            // Applying paint on original home.
            home = new PaintDecorator(home);
            Console.WriteLine("\nPaint applied.Current bill breakups are as follows: ");

            home.MakeHome();
            // Adding a floor on the painted home.
            home = new FloorDecorator(home);
            Console.WriteLine("\nFloor added.Current bill breakups are as follows: ");

            home.MakeHome();
            // Adding another floor on the current home.
            home = new FloorDecorator(home);
            Console.WriteLine("\nFloor added.Current bill breakups are as follows: ");

            home.MakeHome();
            #endregion

            Console.ReadLine();
        }

        private static void CallProxy2Pattern()
        {
            Console.WriteLine("***Proxy Pattern2 Demo***\n");
            // Authorized user - Admin
            Subject proxy = new Proxy2("Admin");
            proxy.DoSomeWork();
            // Authorized user - Sam
            proxy = new Proxy2("Sam");
            proxy.DoSomeWork();
            // Unauthorized user - Robiin
            proxy = new Proxy2("Robin");
            proxy.DoSomeWork();

            Console.ReadLine();
        }

        private static void CallProxyPattern()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
            Console.ReadLine();
        }

        private static void CallFactoryAbstract()
        {
            Console.WriteLine("***Abstract Factory Pattern Demo***\n");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            ITiger tiger = animalFactory.GetTiger();
            dog.AboutMe();
            tiger.AboutMe();

            Console.WriteLine("********************");

            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            tiger = animalFactory.GetTiger();
            dog.AboutMe();
            tiger.AboutMe();

            Console.ReadLine();
        }

        private static void CallFactoryMethod()
        {
            Console.WriteLine("***Factory Pattern Demo***");
            AnimalFactory tigerFactory = new TigerFactory();
            IAnimal tiger = tigerFactory.MakeAnimal();

            AnimalFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.MakeAnimal();

            Console.ReadLine();
        }

        private static void CallFactorySimple()
        {
            Console.WriteLine("*** Simple Factory Pattern Demo ***\n");
            IAnimal preferredType = null;
            SimpleFactory simpleFactory = new SimpleFactory();
            preferredType = simpleFactory.CreateAnimal();
            preferredType.AboutMe();

            Console.ReadLine();
        }

        private static void CallBuilderPattern2()
        {
            Console.WriteLine("***Builder2 Pattern alternative implementation.***");
            Creational_Patterns.Builder2.Product customCar = new Car("Suzuki Swift").StartUpOperations()
                .AddHeadLights(6)
                .InsertWheels()//Will consider default value
                .BuildBody("Plastic")
                .EndOperations("Suzuki construction Completed.")
                .ConstructCar();

            customCar.Show();


            Creational_Patterns.Builder2.Product customCar2 = new Car("Sedan")
                .InsertWheels(7)
                .AddHeadLights(6)
                .StartUpOperations("Sedan creation in progres")
                .BuildBody()
                .EndOperations() //will take default end message
                .ConstructCar();

            customCar2.Show();
        }

        private static void CallBuilderPattern()
        {
            Console.WriteLine("***Builder Pattern Demo***");
            Director director = new Director();

            IBuilder b1 = new Creational_Patterns.Builder.Car("Ford");
            IBuilder b2 = new Motorcycle("Honda");

            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();

            Console.ReadLine();
        }

        private static void Call2PrototypePattern()
        {
            Console.WriteLine("***Prototype Pattern Demo2.***\n");
            CarFactory2 carFactory = new CarFactory2();

            // Get a Nano
            BasicCar basicCar = carFactory.GetNano();
            //Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
           SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");
            // Get a Ford now
            basicCar = carFactory.GetFord();
            // Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
           SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

            Console.ReadLine();
        }

        private static void CallPrototypePattern()
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            BasicCar nano = new Nano("Green Nano");
            BasicCar ford = new Ford("Ford Yellow");
            BasicCar basicCar;

            //Nano
            basicCar = nano.Clone();
            //Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and its price is Rs. {basicCar.onRoadPrice}");

            //Ford
            basicCar = ford.Clone();
            //Working  on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and its price is Rs. {basicCar.onRoadPrice}");

            Console.ReadLine();
        }

        private static void CallSingletonPatterns()
        {
            Console.WriteLine("***Singleton Pattern Demonstration.***\n");
            Console.WriteLine($"The value of MyInt is: {SingletonStaticConstructor.MyInt}");

            //Singleton s = new Singleton(); //error

            Console.WriteLine("Trying to get a Singleton instance, called firstInstance.");

            SingletonStaticConstructor firstInstance = SingletonStaticConstructor.GetInstance;

            Console.WriteLine("Trying to get another Singleton instance, called secondInstance.");

            SingletonStaticConstructor secondInstance = SingletonStaticConstructor.GetInstance;

            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The firstInstance and secondInstance are the same.");
            }
            else
            {
                Console.WriteLine("Different instance exist.");
            }

            Console.WriteLine();

            SingletonDoubleCheckedLock thirdInstance = SingletonDoubleCheckedLock.GetInstance;
            SingletonDoubleCheckedLock fourthInstance = SingletonDoubleCheckedLock.GetInstance;

            if (thirdInstance.Equals(fourthInstance)) Console.WriteLine("The thirdInstance and fourthInstance are the same.");
            else Console.WriteLine("Different instance exist.");
            Console.Read();

            //Console.WriteLine(Singleton.MyInt);
        }
    }
}