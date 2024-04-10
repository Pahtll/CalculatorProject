namespace Calculator.Application;
using AngouriMath;

/// <summary>
/// Класс калькулятора, даёт возмножность обработать входную строку, пользователя и решить её
/// </summary>
/// <param name="expression"></param>
public class Calculator(string expression) : ICalculator
{
    public string Expression { get; init; } = expression;

    public string Calculate()
    {
        var expr = MathS.FromString(Expression);
        return expr.EvalNumerical().Stringize();
    }
}