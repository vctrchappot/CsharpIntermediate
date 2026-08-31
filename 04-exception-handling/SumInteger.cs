namespace _04_exception_handling;

public class SumInteger
{
    public static int[] RetrieveNumbers()
    {
        var numbers = new int[2];
        
        Console.WriteLine("(Your first number is processed with the second)");
        for (var i = 0; i < numbers.Length; i++)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                numbers[i] = input;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid integer!");
            }
        }

        return numbers;
    }

    public static int SumNumbers(int[] numbers)
    {
        var result = numbers[0] + numbers[1];
        return result;
    }
}