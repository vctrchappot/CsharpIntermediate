namespace _06_vertiefung;

public class ConsoleRepeater
{
    public static void WalkX()
    {
        const char x = 'x';
        
        Console.SetCursorPosition(0, 0);
        Console.Write(x);
        
        var widthPos = 0;
        var topPos = 0;
        
        while (true)
        {
            var pressedKey = Console.ReadKey(true);

            if (MovementValidator.IsValidMovement(widthPos, topPos, pressedKey))
            {
                switch (pressedKey.Key)
                {
                    case ConsoleKey.W:
                        topPos--;
                        break;
                    case ConsoleKey.A:
                        widthPos--;
                        break;
                    case ConsoleKey.S:
                        topPos++;
                        break;
                    case ConsoleKey.D:
                        widthPos++;
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(widthPos, topPos);
                Console.Write(x);
            }
        }
    }
}