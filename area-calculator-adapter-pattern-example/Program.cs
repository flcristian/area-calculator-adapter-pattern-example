using area_calculator_adapter_pattern_example;

internal class Program
{
    private static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();
        Console.WriteLine(calculator.GetArea(new Rectangle("rectangle", 2, 3)));
        Console.WriteLine(calculator.GetArea(new Triangle("triangle", 4, 5)));
    }
}