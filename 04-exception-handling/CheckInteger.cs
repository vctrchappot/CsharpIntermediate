namespace _04_exception_handling;

public class CheckInteger {
    
    public static int RetrieveNumber()
    {
        Console.WriteLine("Enter your number:");
        var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        return input;
    }

    public static void CheckIfPositive(int input)
    {
        try
        {
            if (!(input >= 0))
                throw new Exception("Negative number was detected");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}