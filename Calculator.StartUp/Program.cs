﻿using System;
using Calculator.Application;

namespace Calculator.StartUp;

public static class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Write an input u can use basic expressions and also log's, sin, cos, tan, cotan, *^2, etc");
            
            ICalculator calc = new Application.Calculator(Console.ReadLine()!);

            Console.WriteLine($"\nResults of calculation:\n{calc.Calculate()}\nType y if u want to continue.");
            
            if (Console.ReadKey().Key is not (ConsoleKey.Y or ConsoleKey.Enter))
                break;
            
            Console.Clear();
        }
    }
}

