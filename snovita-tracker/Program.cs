namespace life;

internal class Program
{
    public const int GRID_WIDTH = 24;
    public const int GRID_HEIGHT = 12;
    public const string NODE = ".";
    public const int SIMULATION_SPEED_MS = 100;

    static void Main() => Run();

    public static void BuildNodes() 
    {
        for (var i = 0; i < GRID_HEIGHT; i++)
        {
            Console.Write(NODE);

            for (var j = 0; j < GRID_WIDTH - 1; j++)
            {
                Console.Write(NODE);
            }
            Console.WriteLine();
        }
    }

    public static Entity CreateEntity()
    {
        Random random = new();
        int positionY = random.Next(0, GRID_HEIGHT);
        int positionX = random.Next(0, GRID_WIDTH);

        Console.SetCursorPosition(positionX, positionY);
        Entity entity = new("0", positionX, positionY);
        Console.WriteLine(entity.Character);

        return entity;
    }

    public static void Run() 
    {
        BuildNodes();
        Entity entity = CreateEntity();

        while (true)
        {
            Thread.Sleep(SIMULATION_SPEED_MS);
            entity.Move();
        }
    }
}