using Microsoft.VisualBasic;

namespace life;

class Grid
{
    public const int X = 40;
    public const int Y = 20;
    public const char NODE = '.';

    const int POPULATION = 222;
    const int SIMULATION_SPEED_MS = 0;

    const int FOOD_PER_ITERATION = 4;
    public const int ITERATIONS_UNTIL_DEATH = 10;

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
            DisplayControlVariables(iteration);
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
            Population[i].WriteEntity();
        }
    }

    static void DisplayControlVariables(int iteration)
    {
        Console.ForegroundColor = COLOUR;
        Console.SetCursorPosition(X + 2, 0);
        Console.Write(new string(' ', Console.WindowWidth - (X + 2)));

        Console.SetCursorPosition(X + 2, 0);
        Console.Write($"Iteration: {iteration}");

        Console.SetCursorPosition(X + 2, 1);
        Console.Write(new string(' ', Console.WindowWidth - (X + 2)));

        Console.SetCursorPosition(X + 2, 1);
        Console.Write($"Entity Count: {Population.Count}");
    }

    static void Iterate() 
    {
        GenerateFood();
        RemoveDeadEntities();

        foreach (var entity in Population)
        {
            entity.Move();
            entity.IterationsUntilDeath--;

            if (entity.IterationsUntilDeath == 0 && entity.FoodCount != 0)
            {
                entity.FoodCount--;
                entity.IterationsUntilDeath = ITERATIONS_UNTIL_DEATH;
            }

            if (entity.FoodCount >= 2) entity.Reproduce();        
        }

        Thread.Sleep(SIMULATION_SPEED_MS);
    }

    static void RemoveDeadEntities() 
    {
        var entitiesToRemove = Population.Where(entity => entity.IterationsUntilDeath == 0 && entity.FoodCount == 0).ToList();

        foreach (var entity in entitiesToRemove)
        {
            Population.Remove(entity);

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(entity.X, entity.Y);
            Console.Write(NODE);
        }
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