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

        for (var zeile = 0; zeile < (multiDimensionalArray.GetLength(0)) ; zeile++)
        {
            for (var reihe = 0; reihe < (multiDimensionalArray.GetLength(1)); reihe++)
            {
                sum += multiDimensionalArray[zeile, reihe];
            }
        }

        return sum;
    }

    private static int[] SumRow()
    {
        var sum = new int[5];
        
        var multiDimensionalArray = new int[,]
        {
            { 1, 2 }, 
            { 4, 5 }, 
            { 8, 9 }, 
            { 17, 2 }, 
            { 2, 9 }
        };

        for (var zeile = 0; zeile < (multiDimensionalArray.GetLength(0)) ; zeile++)
        {
            for (var reihe = 0; reihe < (multiDimensionalArray.GetLength(1)); reihe++)
            {
                sum[zeile] += multiDimensionalArray[zeile, reihe];
            }
        }

        return sum;
    }
}