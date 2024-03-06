namespace life;

internal class Entity
{
    public int X { get; set; }
    public int Y { get; set; }

    public int IterationsUntilDeath = 10;
    public List<int> FoodCount = new();

    public static char SYMBOL = '0';
    public static ConsoleColor COLOUR = ConsoleColor.Yellow;

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

        int previousX = X;
        int previousY = Y;

        int direction = rnd.Next(4);

        X += direction == 0 ? 1 : (direction == 1 ? -1 : 0);
        Y += direction == 2 ? -1 : (direction == 3 ? 1 : 0);

        if (X < 0 || Y < 0 || X >= Grid.X  || Y >= Grid.Y || 
            Grid.Population.Any(entity => entity != this && entity.X == X && entity.Y == Y))
        {
            X = previousX;
            Y = previousY;
            return;
        }

        if (Grid.FoodList.Any(food => food.X == X && food.Y == Y)) 
        {
            IterationsUntilDeath = 10;
        }

        Console.ForegroundColor = Grid.COLOUR;
        Console.SetCursorPosition(previousX, previousY);
        Console.Write(Grid.NODE);

        Console.SetCursorPosition(X, Y);
        Write();
    }
}
