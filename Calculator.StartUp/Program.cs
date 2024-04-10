using System;
using Calculator.Application;

namespace Calculator.StartUp;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Write an input u can use basic expressions and also log's, sin, cos, tg, ctg, *^2, etc");
            
            ICalculator calc = new Application.Calculator(Console.ReadLine()!);

            Console.WriteLine($"\nResults of calculation:\n{calc.Calculate()}\nType y if u want to continue.");
            
            if (Console.ReadLine() != "y")
                break;
            
            Console.Clear();
        }
    }
}

