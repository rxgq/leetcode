namespace life;

internal class Entity
{
    public int X { get; set; }
    public int Y { get; set; }

    public char SYMBOL = '0';
    public ConsoleColor COLOUR = ConsoleColor.Yellow;

    public Entity(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Write() 
    { 
        Console.ForegroundColor = COLOUR;
        Console.Write(SYMBOL);
        Console.ResetColor();
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

        if (X < 0 || Y < 0 || X >= Grid.X || Y >= Grid.Y || Grid.population.Any(entity => entity != this && entity.X == X && entity.Y == Y))
        {
            X = previousX;
            Y = previousY;
            return;
        }

        Console.SetCursorPosition(previousX, previousY);
        Console.Write(Grid.NODE);

        Console.SetCursorPosition(X, Y);
        Write();
    }
}
