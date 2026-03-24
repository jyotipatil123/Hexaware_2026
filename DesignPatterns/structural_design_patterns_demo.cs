//////// Interface for colors
//////// structural design pattern demo -- bridge design pattern example 

//////// c# 8.0  after

//////using System;
//////public interface IColor
//////{
//////    void ApplyColor();
//////}

//////// Implementation for the red color
//////public class Red : IColor
//////{
//////    public void ApplyColor()
//////    {
//////        Console.WriteLine("Applying red color.");
//////    }
//////}

//////// Implementation for the blue color
//////public class Blue : IColor
//////{
//////    public void ApplyColor()
//////    {
//////        Console.WriteLine("Applying blue color.");
//////    }
//////}

//////// Shape abstraction
//////public abstract class Shape
//////{
//////    protected IColor color;

//////    protected Shape(IColor color)
//////    {
//////        this.color = color;
//////    }
//////    public abstract void Draw();
//////}

//////// Circle implementation
//////public class Circle : Shape
//////{
//////    public Circle(IColor color) : base(color) { }

//////    public override void Draw()
//////    {
//////        Console.WriteLine("Drawing a circle.");
//////        color.ApplyColor();
//////    }
//////}

//////// Square implementation
//////public class Square : Shape
//////{
//////    public Square(IColor color) : base(color) { }

//////    public override void Draw()
//////    {
//////        Console.WriteLine("Drawing a square.");
//////        color.ApplyColor();
//////    }
//////}

//////class Program
//////{
//////    static void Main(string[] args)
//////    {
//////        // Drawing a red circle
//////        Shape redCircle = new Circle(new Red());
//////        redCircle.Draw();  // Output: Drawing a circle. Applying red color.

//////        // Drawing a blue square
//////        Shape blueSquare = new Square(new Blue());
//////        blueSquare.Draw();  // Output: Drawing a square. Applying blue color.
//////    }
//////}

////// composite design pattern demo

////using System;
////using System.Collections.Generic;

////namespace Composite.Structural
////{
////    /// <summary>
////    /// Composite Design Pattern
////    /// </summary>

////    public class Program
////    {
////        public static void Main(string[] args)
////        {
////            // Create a tree structure

////            Composite root = new Composite("root");
////            root.Add(new Leaf("Leaf A"));
////            root.Add(new Leaf("Leaf B"));

////            Composite comp = new Composite("Composite X");
////            comp.Add(new Leaf("Leaf XA"));
////            comp.Add(new Leaf("Leaf XB"));

////            root.Add(comp);
////            root.Add(new Leaf("Leaf C"));

////            // Add and remove a leaf

////            Leaf leaf = new Leaf("Leaf D");
////            root.Add(leaf);
////            root.Remove(leaf);

////            // Recursively display tree

////            root.Display(1);

////            // Wait for user

////            Console.ReadKey();
////        }
////    }

////    /// <summary>
////    /// The 'Component' abstract class
////    /// </summary>

////    public abstract class Component
////    {
////        protected string name;

////        // Constructor

////        public Component(string name)
////        {
////            this.name = name;
////        }

////        public abstract void Add(Component c);
////        public abstract void Remove(Component c);
////        public abstract void Display(int depth);
////    }

////    /// <summary>
////    /// The 'Composite' class
////    /// </summary>

////    public class Composite : Component
////    {
////        List<Component> children = new List<Component>();

////        // Constructor

////        public Composite(string name)
////            : base(name)
////        {
////        }

////        public override void Add(Component component)
////        {
////            children.Add(component);
////        }

////        public override void Remove(Component component)
////        {
////            children.Remove(component);
////        }

////        public override void Display(int depth)
////        {
////            Console.WriteLine(new String('-', depth) + name);

////            // Recursively display child nodes

////            foreach (Component component in children)
////            {
////                component.Display(depth + 2);
////            }
////        }
////    }

////    /// <summary>
////    /// The 'Leaf' class
////    /// </summary>

////    public class Leaf : Component
////    {
////        // Constructor

////        public Leaf(string name)
////            : base(name)
////        {
////        }

////        public override void Add(Component c)
////        {
////            Console.WriteLine("Cannot add to a leaf");
////        }

////        public override void Remove(Component c)
////        {
////            Console.WriteLine("Cannot remove from a leaf");
////        }

////        public override void Display(int depth)
////        {
////            Console.WriteLine(new String('-', depth) + name);
////        }
////    }
////}


////decorator design pattern
//using System;

//// Step 1: Component Interface
//public interface ICoffee
//{
//    string GetDescription();
//    double GetCost();
//}

//// Step 2: Concrete Component
//public class SimpleCoffee : ICoffee
//{
//    public string GetDescription()
//    {
//        return "Simple Coffee";
//    }

//    public double GetCost()
//    {
//        return 50;
//    }
//}

//// Step 3: Base Decorator
//public abstract class CoffeeDecorator : ICoffee
//{
//    protected ICoffee coffee;

//    public CoffeeDecorator(ICoffee coffee)
//    {
//        this.coffee = coffee;
//    }

//    public virtual string GetDescription()
//    {
//        return coffee.GetDescription();
//    }

//    public virtual double GetCost()
//    {
//        return coffee.GetCost();
//    }
//}

//// Step 4: Concrete Decorator - Milk
//public class MilkDecorator : CoffeeDecorator
//{
//    public MilkDecorator(ICoffee coffee) : base(coffee) { }

//    public override string GetDescription()
//    {
//        return coffee.GetDescription() + ", Milk";
//    }

//    public override double GetCost()
//    {
//        return coffee.GetCost() + 10;
//    }
//}

//// Step 5: Concrete Decorator - Sugar
//public class SugarDecorator : CoffeeDecorator
//{
//    public SugarDecorator(ICoffee coffee) : base(coffee) { }

//    public override string GetDescription()
//    {
//        return coffee.GetDescription() + ", Sugar";
//    }

//    public override double GetCost()
//    {
//        return coffee.GetCost() + 5;
//    }
//}

//// Step 6: Main Program (Client)
//class Program
//{
//    static void Main(string[] args)
//    {
//        ICoffee coffee = new SimpleCoffee();

//        // Add Milk
//        coffee = new MilkDecorator(coffee);

//        // Add Sugar
//        coffee = new SugarDecorator(coffee);

//        Console.WriteLine("Order: " + coffee.GetDescription());
//        Console.WriteLine("Total Cost: " + coffee.GetCost());

//        Console.ReadLine();
//    }
//}