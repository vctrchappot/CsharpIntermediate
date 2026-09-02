namespace _06_vertiefung;

public class ConsoleRepeater
{
    public static void WalkX()
    {
        const char x = 'x';
        
        var widthPos = 0;
        var heightPos = 0;
        
        Console.SetCursorPosition(widthPos, heightPos);
        Console.Write(x);
        
        while (true)
        {
            var pressedKey = Console.ReadKey(true);

            if (MovementValidator.IsValidMovement(widthPos, heightPos, pressedKey))
            {
                switch (pressedKey.Key)
                {
                    case ConsoleKey.W:
                        heightPos--;
                        break;
                    case ConsoleKey.A:
                        widthPos--;
                        break;
                    case ConsoleKey.S:
                        heightPos++;
                        break;
                    case ConsoleKey.D:
                        widthPos++;
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(widthPos, heightPos);
                Console.Write(x);
            }
        }
    }
}