namespace _02_multidimensional_arrays;

class Program
{
    static void Main(string[] args)
    {
        var summedRow = SumRow();
        Console.WriteLine(string.Join(", ", summedRow));
    }

    private static int SumArray() // KEIN CHATGPT BENUTZT WOWWW SOOO SCHLAU YAY :DDDDDD
    {
        var sum = 0;
        
        var multiDimensionalArray = new int[,]
        {
            { 1, 2 }, 
            { 4, 5 }, 
            { 8, 9 }, 
            { 17, 2 }, 
            { 2, 9 }
        };

        for (var row = 0; row < (multiDimensionalArray.GetLength(0)) ; row++)
        {
            for (var column = 0; column < (multiDimensionalArray.GetLength(1)); column++)
            {
                sum += multiDimensionalArray[row, column];
            }
        }

        return sum;
    }

    private static int[] SumRow()
    {
        var multiDimensionalArray = new int[,]
        {
            { 1, 2 }, 
            { 4, 5 }, 
            { 8, 9 }, 
            { 17, 2 }, 
            { 2, 9 }
        };
        
        var sum = new int[multiDimensionalArray.GetLength(0)];

        for (var row = 0; row < (multiDimensionalArray.GetLength(0)) ; row++)
        {
            for (var column = 0; column < (multiDimensionalArray.GetLength(1)); column++)
            {
                sum[row] += multiDimensionalArray[row, column];
            }
        }

        return sum;
    }
}