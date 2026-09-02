namespace _06_vertiefung;

public static class MovementValidator
{
    public static bool IsValidMovement(int widthPos, int topPos, ConsoleKeyInfo pressedKey)
    {

        switch (pressedKey.Key)
        {
            case ConsoleKey.W:
            {
                return topPos > 0;
            }
            case ConsoleKey.A:
            {
                return widthPos > 0;
            }
            case ConsoleKey.S:
            {
                return topPos+1 < Console.WindowHeight;
            }
            case ConsoleKey.D:
            {
                return widthPos+1 < Console.WindowWidth;
            }
            default:
                return false;
        }
    }
}