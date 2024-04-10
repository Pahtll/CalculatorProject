namespace Calculator.Application;

public interface ICalculator
{
    string Expression { get; init; }
    string Calculate();
}