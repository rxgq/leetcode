namespace life;

internal class Entity
{
    public int X { get; set; }
    public int Y { get; set; }

    public int IterationsUntilDeath = Grid.ITERATIONS_UNTIL_DEATH;
    public int FoodCount = 0;

    public const char SYMBOL = '0';
    public const ConsoleColor COLOUR = ConsoleColor.Yellow;

    static Random rnd = new();

    public Entity(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void WriteEntity()
    {
        Console.ForegroundColor = COLOUR;
        Console.Write(SYMBOL);

        Console.ResetColor();
    }

    public void Move()
    {
        int previousX = X;
        int previousY = Y;

        int direction = rnd.Next(4);

        X += direction == 0 ? 1 : (direction == 1 ? -1 : 0);
        Y += direction == 2 ? -1 : (direction == 3 ? 1 : 0);

        if (X < 0 || Y < 0 || X >= Grid.X || Y >= Grid.Y ||
            Grid.Population.Any(entity => entity != this && entity.X == X && entity.Y == Y))
        {
            X = previousX;
            Y = previousY;
            return;
        }

        var foundFood = Grid.FoodList.FirstOrDefault(food => food.X == X && food.Y == Y);

        if (foundFood is not null && FoodCount < 2)
        {
            Grid.FoodList.Remove(foundFood);
            FoodCount++;
        }

        Console.ForegroundColor = Grid.COLOUR;
        Console.SetCursorPosition(previousX, previousY);
        Console.Write(Grid.NODE);

        Console.SetCursorPosition(X, Y);
        WriteEntity();
    }

    public void Reproduce()
    {
        FoodCount--;

        int offsetX = rnd.Next(-1, 2), offsetY = rnd.Next(-1, 2);
        int newX = X + offsetX, newY = Y + offsetY;

        if (newX >= 0 && newY >= 0 && newX < Grid.X && newY < Grid.Y &&
            !Grid.Population.Any(entity => entity.X == newX && entity.Y == newY))
        {
            List<Entity> newPopulation = new(Grid.Population)
            {
                new Entity(newX, newY)
            };

            Grid.Population = newPopulation;
        }
    }
}
