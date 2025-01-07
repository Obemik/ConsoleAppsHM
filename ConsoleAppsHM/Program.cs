using RangeProductCalculator;

try
{
    Console.WriteLine("Enter the start of the range:");
    int start = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

    Console.WriteLine("Enter the end of the range:");
    int end = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

    var result = Calculator.GetProductInRange(start, end);
    Console.WriteLine($"The product of numbers from {start} to {end} is: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}