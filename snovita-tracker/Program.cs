namespace life;

class Grid
{
    public const int X = 20;
    public const int Y = 10;
    public const char NODE = '.';

    const int POPULATION = 100;
    const int SIMULATION_SPEED_MS = 300;

    public static List<Entity> population = new();

    static void Main() 
    {
        BuildGrid();
        PopulateGrid();

        while (true) 
        {
            foreach (var entity in population) 
            {
                entity.Move();
            }

            Thread.Sleep(SIMULATION_SPEED_MS);
        }
    }

    static void BuildGrid()
    {
        for (int i = 0; i < Y; i++)
        {
            Console.Write(NODE);

            for (int j = 0; j < X; j++)
            {
                Console.Write(NODE);
            }
            Console.WriteLine();
        }
    }

    static void PopulateGrid() 
    {
        Random rnd = new();

        for (int i = 0; i < POPULATION; i++)
        {
            int randX = rnd.Next(X + 1);
            int randY = rnd.Next(Y);

            Entity entity = new(randX, randY);
            population.Add(entity);

            Console.SetCursorPosition(randX, randY);
            entity.Write();
        }
    }
}