namespace _04_exception_handling;

public class SumInteger
{
    public static int SumNumbers()
    {
        Console.WriteLine("First number:");
        var firstNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        Console.WriteLine("First number:");
        var secondNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        var result = firstNumber + secondNumber;

        return result;
    }
}