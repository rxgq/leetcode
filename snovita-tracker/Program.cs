using Microsoft.VisualBasic;

namespace life;

class Grid
{
    public const int X = 20;
    public const int Y = 10;
    public const char NODE = '.';

    const int POPULATION = 100;
    const int SIMULATION_SPEED_MS = 0;

    public static List<Entity> population = new();
    static Random rnd = new();

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
        for (int i = 0; i < Y; i++)
        {
            Console.WriteLine(new string(NODE, X + 1));
        }
    }

    static void PopulateGrid() 
    {
        for (int i = 0; i < POPULATION; i++)
        {
            int randX = rnd.Next(X + 1), randY = rnd.Next(Y);

            population.Add(new Entity(randX, randY));

            Console.SetCursorPosition(randX, randY); 
            population[i].Write();
        }
    }
}