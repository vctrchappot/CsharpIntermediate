namespace _06_vertiefung;

public class ConsoleRepeater
{
    public static void WalkX()
    {
        const char x = 'x';
        
        Console.SetWindowSize(120, 60);
        Console.SetCursorPosition(60, 30);
        Console.Write(x);
        
        var widthPos = 0;
        var topPos = 0;
        Console.SetCursorPosition(widthPos, topPos);
        var key = Console.ReadKey(true);
        
        while (true)
        {
            switch (key.Key)
            {
                case ConsoleKey.W:
                    topPos++;
                    Console.Clear();
                    Console.SetCursorPosition(widthPos, topPos);
                    Console.Write(x);
                    break;
                case ConsoleKey.A:
                    widthPos--;
                    Console.Clear();
                    Console.SetCursorPosition(widthPos, topPos);
                    Console.Write(x);
                    break;
                case ConsoleKey.S:
                    topPos--;
                    Console.Clear();
                    Console.SetCursorPosition(widthPos, topPos);
                    Console.Write(x);
                    break;
                case ConsoleKey.D:
                    widthPos++;
                    Console.Clear();
                    Console.SetCursorPosition(widthPos, topPos);
                    Console.Write(x);
                    break;
            }
        }
    }
}