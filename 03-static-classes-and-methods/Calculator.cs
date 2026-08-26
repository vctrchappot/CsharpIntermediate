namespace _03_static_classes_and_methods;

public class Calculator
{
    public static int[] RetrieveNumbers()
    {
        var numbers = new int[2];
        
        Console.WriteLine("(Your first number is processed with the second)");
        for (var i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number:");
            var input = int.Parse(Console.ReadLine());
            numbers[i] = input;
        }

        return numbers;
    }

    public static string[] SelectOperator(int[] numbers)
    {
        Console.WriteLine("Select the desired arithmetic operator:");
        Console.WriteLine("1. +");
        Console.WriteLine("2. -");
        Console.WriteLine("3. *");
        Console.WriteLine("4. /");

        var input = Convert.ToInt32(Console.ReadLine());
        var result = new string[2];
        
        switch (input)
        {
            case 1:
                result[0] = Convert.ToString(numbers[0] + numbers[1]);
                result[1] = "added to";
                break;
            case 2:
                result[0] = Convert.ToString(numbers[0] - numbers[1]);
                result[1] = "subtracted from";
                break;
            case 3:
                result[0] = Convert.ToString(numbers[0] * numbers[1]);
                result[1] = "multiplied by";
                break;
            case 4:
                result[1] = "divided by";

                if (numbers[1] is 0)
                {
                    result[0] = "Error: Division by zero";
                }
                else
                {
                    result[0] = $"{numbers[0] / numbers[1]}";
                }
                break;


            default:
                Console.WriteLine("Invalid operator selected.");
                break;
        }

        return result;
    }
}