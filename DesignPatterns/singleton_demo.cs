////////////// singleton pattern demo

////////////using System;

////////////namespace Console_Hexaware_demo1.DesignPatterns
////////////{
////////////    class SingletonClass
////////////    {
////////////        // Private static variable to hold the single instance of the class
////////////        private static SingletonClass instance;


////////////        // Private constructor to prevent instantiation from outside the class
////////////        private SingletonClass()
////////////        {
////////////        }

////////////        // Public static property to provide access to the single instance
////////////        public static SingletonClass Instance
////////////        {
////////////            get
////////////            {
////////////                if (instance == null)
////////////                {
////////////                    instance = new SingletonClass();
////////////                }
////////////                return instance;
////////////            }
////////////        }
////////////    }

////////////    class singleton_demo
////////////    {
////////////        public static void Main(string[] args)
////////////        {
////////////            Console.WriteLine("Singleton Pattern Demo");

////////////            // Get the single instance of the singleton class
////////////            SingletonClass instance1 = SingletonClass.Instance;

////////////            SingletonClass instance2 = SingletonClass.Instance;

////////////            SingletonClass instance3= new SingletonClass();  //error because constructor is private


////////////            // Check if both instances are the same
////////////            if (instance3 == instance1)
////////////            {
////////////                Console.WriteLine("Both instances are the same. Singleton pattern works!");
////////////            }
////////////            else
////////////            {
////////////                Console.WriteLine("Instances are different. Singleton pattern failed.");
////////////            }
////////////        }
////////////    }
////////////}


//////////// Factory method demo

//////////using System;

//////////class Product
//////////{
//////////    public virtual void Display()
//////////    {
//////////        Console.WriteLine("This is a product.");
//////////    }
//////////}

//////////class ConcreteProductA : Product
//////////{
//////////    public override void Display()
//////////    {
//////////        Console.WriteLine("This is Concrete Product A.");
//////////    }
//////////}

//////////class ConcreteProductB : Product
//////////{
//////////    public override void Display()
//////////    {
//////////        Console.WriteLine("This is Concrete Product B.");
//////////    }
//////////}

//////////class Factory
//////////{
//////////    public static Product CreateProduct(string type)
//////////    {
//////////        if (type == "A")
//////////        {
//////////            return new ConcreteProductA();
//////////        }
//////////        else if (type == "B")
//////////        {
//////////            return new ConcreteProductB();
//////////        }
//////////        else
//////////        {
//////////            throw new ArgumentException("Invalid product type.");
//////////        }
//////////    }
//////////}

//////////class factory_method_demo
//////////{
//////////    public static void Main(string[] args)
//////////    {
//////////        Console.WriteLine("Factory Method Pattern Demo");

//////////        // Create products using the factory method

//////////        Product productA = Factory.CreateProduct("A");
//////////        Product productB = Factory.CreateProduct("B");
//////////        Product p1= Factory.CreateProduct("C");  //error because invalid product type


//////////        // Display the products
//////////        productA.Display();
//////////        productB.Display();
//////////        p1.Display(); 
//////////    }
//////////}
//////////====================================================================================
//////////  Abstract Factory demo

////////using System;

////////class AbstractProductA
////////{
////////    public virtual void Display()
////////    {
////////        Console.WriteLine("This is Abstract Product A.");
////////    }
////////}

////////class AbstractProductB
////////{
////////    public virtual void Display()
////////    {
////////        Console.WriteLine("This is Abstract Product B.");
////////    }
////////}

////////class AbstractFactory
////////{
////////    public static AbstractProductA CreateProductA()
////////    {
////////        return new AbstractProductA();
////////    }
////////    public static AbstractProductB CreateProductB()
////////    {
////////        return new AbstractProductB();
////////    }
////////}

////////class abstract_factory_demo
////////{
////////    public static void Main(string[] args)
////////    {
////////        Console.WriteLine("Abstract Factory Pattern Demo");

////////        // Create products using the abstract factory
////////        AbstractProductA productA = AbstractFactory.CreateProductA();
////////        AbstractProductB productB = AbstractFactory.CreateProductB();

////////        // Display the products
////////        productA.Display();
////////        productB.Display();
////////    }
////////}

////////====================================================================================

//////// Builder design pattern demo

//////using System;

//////class Product
//////{
//////    public string Name { get; set; }
//////    public decimal Price { get; set; }
//////    public string Description { get; set; }
//////    public void Display()
//////    {
//////        Console.WriteLine($"Product: {Name}, Price: {Price}, Description: {Description}");
//////    }
//////}

//////class ProductBuilder
//////{
//////    private Product product;
//////    public ProductBuilder()
//////    {
//////        product = new Product();
//////    }
//////    public ProductBuilder SetName(string name)
//////    {
//////        product.Name = name;
//////        return this;
//////    }
//////    public ProductBuilder SetPrice(decimal price)
//////    {
//////        product.Price = price;
//////        return this;
//////    }
//////    public ProductBuilder SetDescription(string description)
//////    {
//////        product.Description = description;
//////        return this;
//////    }
//////    public Product Build()
//////    {
//////        return product;
//////    }
//////}

//////class builder_demo
//////{
//////    public static void Main(string[] args)
//////    {
//////        Console.WriteLine("Builder Pattern Demo");


//////        // Create a product using the builder pattern
//////        Product product = new ProductBuilder()
//////            .SetName("Laptop")
//////            .SetPrice(999.99m)
//////            .SetDescription("A high-performance laptop.")
//////            .Build();


//////        // Display the product
//////        product.Display();
//////    }
//////}

//////==============================================================================================

////// Prototype design pattern demo

////using System;

////class Prototype
////{
////    public string Name { get; set; }
////    public int Value { get; set; }
////    public Prototype Clone()
////    {
////        return (Prototype)this.MemberwiseClone();
////    }
////}

////class prototype_demo
////{
////    public static void Main(string[] args)
////    {
////        Console.WriteLine("Prototype Pattern Demo");

////        // Create an instance of the prototype
////        Prototype original = new Prototype { Name = "Original", Value = 42 };


////        // Clone the prototype
////        Prototype clone = original.Clone();


////        // Display the original and cloned objects
////        Console.WriteLine($"Original: Name={original.Name}, Value={original.Value}");
////        Console.WriteLine($"Clone: Name={clone.Name}, Value={clone.Value}");
////    }
////}

////======================================================================

////strctural design pattern demo


//// Adapter design pattern demo
//using System;

//class Target
//{
//    public virtual void Request()
//    {
//        Console.WriteLine("Target: Request method called.");
//    }
//}

//class Adaptee
//{
//    public void SpecificRequest()
//    {
//        Console.WriteLine("Adaptee: SpecificRequest method called.");
//    }
//}

//class Adapter : Target
//{
//    private Adaptee adaptee;
//    public Adapter(Adaptee adaptee)
//    {
//        this.adaptee = adaptee;
//    }
//    public override void Request()
//    {
//        Console.WriteLine("Adapter: Request method called. Adapting to Adaptee...");
//        adaptee.SpecificRequest();
//    }
//}

//class adapter_demo
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Adapter Pattern Demo");

//        // Create an instance of the adaptee
//        Adaptee adaptee = new Adaptee();


//        // Create an adapter that wraps the adaptee
//        Target adapter = new Adapter(adaptee);


//        // Call the request method on the adapter
//        adapter.Request();
//    }
//}

