namespace life;

internal class Food
{
    public int X { get; set; }
    public int Y { get; set; }

    public static char SYMBOL = 'C';
    public static ConsoleColor COLOUR = ConsoleColor.Cyan;

    public Food(int x, int y) 
    {
        X = x;
        Y = y;
    }
}
