////// Behavioral design pattern

////using System;

////// Step 1: Abstract Handler
////public abstract class NumberHandler
////{
////    protected NumberHandler next;

////    public void SetNext(NumberHandler nextHandler)
////    {
////        next = nextHandler;
////    }

////    public void Process(int number)
////    {
////        if (Handle(number))
////            return;

////        if (next != null)
////            next.Process(number);
////        else
////            Console.WriteLine("No handler found for " + number);
////    }

////    protected abstract bool Handle(int number);
////}

////// Step 2: Concrete Handlers

////// Even Number Handler
////public class EvenHandler : NumberHandler
////{
////    protected override bool Handle(int number)
////    {
////        if (number % 2 == 0 && number >= 0)
////        {
////            Console.WriteLine(number + " is Even");
////            return true;
////        }
////        return false;
////    }
////}

////// Odd Number Handler
////public class OddHandler : NumberHandler
////{
////    protected override bool Handle(int number)
////    {
////        if (number % 2 != 0 && number >= 0)
////        {
////            Console.WriteLine(number + " is Odd");
////            return true;
////        }
////        return false;
////    }
////}

////// Negative Number Handler
////public class NegativeHandler : NumberHandler
////{
////    protected override bool Handle(int number)
////    {
////        if (number < 0)
////        {
////            Console.WriteLine(number + " is Negative");
////            return true;
////        }
////        return false;
////    }
////}

////// Step 3: Client
////class Program
////{
////    static void Main()
////    {
////        NumberHandler even = new EvenHandler();
////        NumberHandler odd = new OddHandler();
////        NumberHandler negative = new NegativeHandler();

////        // Chain setup
////        even.SetNext(odd);
////        odd.SetNext(negative);

////        int[] numbers = { 10, 7, -5, 8, 3 };

////        foreach (var num in numbers)
////        {
////            even.Process(num);
////        }

////        Console.ReadLine();
////    }
////}

////=====================================================================
////command design pattern demo

//using System;

//public interface ICommand
//{
//    void Execute();
//}

//public class LightOnCommand : ICommand
//{
//    private readonly Light _light;

//    public LightOnCommand(Light light)
//    {
//        _light = light;
//    }

//    public void Execute()
//    {
//        _light.TurnOn();
//    }
//}

//public class LightOffCommand : ICommand
//{
//    private readonly Light _light;

//    public LightOffCommand(Light light)
//    {
//        _light = light;
//    }

//    public void Execute()
//    {
//        _light.TurnOff();
//    }
//}

//public class Light
//{
//    public void TurnOn()
//    {
//        Console.WriteLine("Light is ON");
//    }

//    public void TurnOff()
//    {
//        Console.WriteLine("Light is OFF");
//    }
//}

//public class RemoteControl
//{
//    private ICommand _command;

//    public void SetCommand(ICommand command)
//    {
//        _command = command;
//    }

//    public void PressButton()
//    {
//        _command.Execute();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Light livingRoomLight = new Light();
//        ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
//        ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

//        RemoteControl remote = new RemoteControl();

//        remote.SetCommand(livingRoomLightOn);
//        remote.PressButton(); // Light is ON

//        remote.SetCommand(livingRoomLightOff);
//        remote.PressButton(); // Light is OFF
//    }
//}


//=============================================
// interpreter design pattern

using System;
using System;

// Step 1: Expression Interface
public interface IExpression
{
    int Interpret();
}

// Step 2: Terminal Expression (Number)
public class NumberExpression : IExpression
{
    private int number;

    public NumberExpression(int number)
    {
        this.number = number;
    }

    public int Interpret()
    {
        return number;
    }
}

// Step 3: Non-Terminal Expression (Addition)
public class AddExpression : IExpression
{
    private IExpression left;
    private IExpression right;

    public AddExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret()
    {
        return left.Interpret() + right.Interpret();
    }
}

// Step 4: Client
class Program
{
    static void Main()
    {
        // Expression: 5 + 3
        IExpression num1 = new NumberExpression(5);
        IExpression num2 = new NumberExpression(3);

        IExpression addition = new AddExpression(num1, num2);

        Console.WriteLine("Result: " + addition.Interpret());

        Console.ReadLine();
    }
}