namespace life;

internal class Entity
{
    public int X { get; set; }
    public int Y { get; set; }

    public char SYMBOL = '0';
    public ConsoleColor COLOUR = ConsoleColor.Blue;

    public Entity(int x, int y) 
    {
        X = x;
        Y = y;
    }

    public void Move() 
    {
        Random rnd = new();

        int direction = rnd.Next(4);

        int previousX = X;
        int previousY = Y;

        switch (direction) 
        {
            case 0:
                X += 1; // right
                break;

            case 1:
                X -= 1; // left
                break;

            case 2:
                Y -= 1; // up
                break;

            case 3:
                Y += 1; // down
                break;
        }

        if (X >= Console.WindowWidth - 1 || Y >= Console.WindowHeight - 1 || X < 0 || Y < 0
            || X >= Grid.X || Y >= Grid.Y)
        {
            X = previousX;
            Y = previousY;
            return;
        }

        Console.SetCursorPosition(previousX, previousY);
        Console.Write(Grid.NODE);

        Console.SetCursorPosition(X, Y);
        Console.Write(SYMBOL);
    }
}
