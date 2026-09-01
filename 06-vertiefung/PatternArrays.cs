namespace _06_vertiefung;

public static class PatternArrays
{
    public static bool[,] SelectPattern()
    {
        Console.WriteLine("Wähle das gewünschte Muster: 1) Weihnachtsbaum, 2) Netz, 3) Kreuz");
        var selection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        var christmasTree = new bool[,]
        {
            { false, false, false, false, true,  false, false, false, false },
            { false, false, false, true,  false, true,  false, false, false },
            { false, false, true,  false, true,  false, true,  false, false },
            { false, true,  false, true,  false, true,  false, true,  false },
            { true,  false, true,  false, true,  false, true,  false, true  },
            { false, false, false, false, true,  false, false, false, false }
        };
        
        var grid = new bool[,]
        {
            { true,  false, true,  false, true,  false, true,  false, true  },
            { false, true,  false, true,  false, true,  false, true,  false },
            { true,  false, true,  false, true,  false, true,  false, true  },
            { false, true,  false, true,  false, true,  false, true,  false },
            { true,  false, true,  false, true,  false, true,  false, true  },
            { false, true,  false, true,  false, true,  false, true,  false }
        };

        var cross = new bool[,]
        {
            { false, false, false, true,  true,  true,  false, false, false },
            { false, false, false, true,  true,  true,  false, false, false },
            { true,  true,  true,  true,  true,  true,  true,  true,  true  },
            { true,  true,  true,  true,  true,  true,  true,  true,  true  },
            { false, false, false, true,  true,  true,  false, false, false },
            { false, false, false, true,  true,  true,  false, false, false }
        };
        
        switch (selection)
        {
            case 1:
                return christmasTree;
            case 2:
                return grid;
            case 3:
                return cross;
            default:
                throw new InvalidOperationException("Invalid Input!");
        }    
    }
    
    public static void PrintPattern(bool[,] selection)
    {
        for (var row = 0; row < selection.GetLength(0); row++)
        {
            for (var column = 0; column < selection.GetLength(1); column++)
            {
                Console.Write(selection[row, column] == true ? 'x' : ' ');
            }
            Console.WriteLine();  
        }
    }
}