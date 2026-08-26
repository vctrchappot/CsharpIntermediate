namespace _03_static_classes_and_methods;

class Program
{
    static void Main(string[] args) // Main Methoden sind immer statisch, da keine Instanzen davon erstellt werden können.
    {
        var numbers = Calculator.RetrieveNumbers();
        var result = Calculator.SelectOperator(numbers);
        Console.WriteLine($"The result {numbers[0]} {result[1]} {numbers[1]} is {result[0]}");
    }
}