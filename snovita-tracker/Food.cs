namespace life;

internal class Food
{
    public int X { get; set; }
    public int Y { get; set; }

    public static char SYMBOL = '+';
    public static ConsoleColor COLOUR = ConsoleColor.Green;

    public Food(int x, int y) 
    {
        X = x;
        Y = y;
    }
}
