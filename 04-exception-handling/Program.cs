using System.Runtime.CompilerServices;

namespace _04_exception_handling;

class Program
{
    private static void Main(string[] args)
    {
        var input = SumInteger.RetrieveNumbers();
        var result = SumInteger.SumNumbers(input);
    }
}

