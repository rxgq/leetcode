using Microsoft.VisualBasic;

namespace life;

class Grid
{
    public const int X = 40;
    public const int Y = 20;
    public const char NODE = '.';

    const int POPULATION = 20;
    const int SIMULATION_SPEED_MS = 250;

    const int FOOD_PER_ITERATION = 8;

    public static ConsoleColor COLOUR = ConsoleColor.White;  

    public static List<Entity> Population = new();
    public static List<Food> FoodList = new();

    static readonly Random rnd = new();

    static void Main() 
    {
        BuildGrid();
        PopulateGrid();

        int iteration = 0;

        while (true)
        {
            Console.SetCursorPosition(X + 2, 0);
            Console.Write($"Iteration: {iteration}");

            Iterate();

            iteration++;
        }
    }

    static void BuildGrid()
    {
        Console.ForegroundColor = COLOUR;

        for (int i = 0; i < Y; i++)
        {
            Console.WriteLine(new string(NODE, X));
        }
    }

    static void PopulateGrid()
    {
        for (int i = 0; i < POPULATION; i++)
        {
            int randX, randY;

            do
            {
                randX = rnd.Next(X);
                randY = rnd.Next(Y);

            } while (Population.Any(entity => entity.X == randX && entity.Y == randY));

            Population.Add(new Entity(randX, randY));

            Console.SetCursorPosition(randX, randY);
            Population[i].Write();
        }
    }

    static void Iterate() 
    {
        GenerateFood();

        var entitiesToRemove = Population.Where(entity => entity.IterationsUntilDeath == 0).ToList();

        foreach (var entity in entitiesToRemove)
        {
            Population.Remove(entity);
            Console.SetCursorPosition(entity.X, entity.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(NODE);
        }

        foreach (var entity in Population)
        {
            entity.Move();
            entity.IterationsUntilDeath--;
        }

        Thread.Sleep(SIMULATION_SPEED_MS);
    }

    static void GenerateFood() 
    {
        for (int i = 0; i < FOOD_PER_ITERATION; i++) 
        {
            int randX = rnd.Next(X), randY = rnd.Next(Y);

            Food food = new(randX, randY);
            FoodList.Add(food);

            Console.ForegroundColor = Food.COLOUR;

            Console.SetCursorPosition(randX, randY);
            Console.Write(Food.SYMBOL);
        }   
    }
}