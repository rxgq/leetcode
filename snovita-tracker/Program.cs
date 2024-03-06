using Microsoft.VisualBasic;

namespace life;

class Grid
{
    public const int X = 20;
    public const int Y = 10;
    public const char NODE = '.';

    const int POPULATION = 20;
    const int SIMULATION_SPEED_MS = 100;

    public static ConsoleColor COLOUR = ConsoleColor.White;  

    public static List<Entity> population = new();
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

    static void Iterate() 
    {
        foreach (var entity in population)
        {
            entity.Move();
        }

        Thread.Sleep(SIMULATION_SPEED_MS);
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

            } while (population.Any(entity => entity.X == randX && entity.Y == randY));

            population.Add(new Entity(randX, randY));

            Console.SetCursorPosition(randX, randY);
            population[i].Write();
        }
    }
}