using Microsoft.VisualBasic;

namespace life;

internal class Program
{
    public const int GRID_WIDTH = 24;
    public const int GRID_HEIGHT = 12;
    public const string NODE = ".";
    public const int SIMULATION_SPEED_MS = 100;
    public const int ENTITY_COUNT = 25;
    public const int ENTITY_LIST_POSITION_X = 111;

    static readonly List<Entity> entities = new();

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

    public static List<Entity> CreateEntities()
    {
        Random random = new();

        int entityID = 0;


        for (int i = 0; i < ENTITY_COUNT; i++)
        {
            string entityName = $"Entity {entityID++}";

            int positionY = random.Next(0, GRID_HEIGHT);
            int positionX = random.Next(0, GRID_WIDTH);

            Console.SetCursorPosition(positionX, positionY);
            Entity entity = new(entityName, "O", positionX, positionY);

            entities.Add(entity);
        }
        return entities;
    }

    public static void Run()
    {
        BuildNodes();

        List<Entity> entities = CreateEntities();
        int iteration = -1;

        while (true)
        {
            iteration++;
            DisplayControlVariables(iteration);

            Thread.Sleep(SIMULATION_SPEED_MS);

            foreach (Entity entity in entities)
            {
                entity.Move();
            }
        }
    }

    public static void DisplayControlVariables(int iteration) 
    {

        Console.SetCursorPosition(25, 0);
        Console.WriteLine($"Iteration {iteration}");

        int entityIDCounter = -1;
        foreach (Entity entity in entities)
        {
            entityIDCounter++;
            Console.SetCursorPosition(ENTITY_LIST_POSITION_X, entityIDCounter);
            Console.Write(entity.EntityName);
        }
    }
}