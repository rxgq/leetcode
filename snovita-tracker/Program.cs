using System.Reflection.PortableExecutable;

namespace life;

internal class Program
{
    public const int GRID_WIDTH = 16;
    public const int GRID_HEIGHT = 8;
    public const string NODE = ".";
    public const int SIMULATION_SPEED_MS = 1000;
    public const int ENTITY_COUNT = 2;
    public const int FOOD_COUNT = 5;
    public const int ENTITY_LIST_POSITION_X = 111;
    public const int ITERATION_POSITION_X = GRID_WIDTH + 1;

    static readonly List<Entity> ListOfEntities = new();
    public static readonly List<Food> ListOfFood = new();

    public static Random Random = new();

    static void Main() => BuildSimulation();

    public static void BuildSimulation()
    {
        BuildNodes();

        List<Entity> entities = CreateEntities();
        CreateFood();

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
        int entityID = 1;

        for (int i = 0; i < ENTITY_COUNT; i++)
        {
            string entityName = $"Entity {entityID++}";

            int positionY = Random.Next(0, GRID_HEIGHT);
            int positionX = Random.Next(0, GRID_WIDTH);

            Console.SetCursorPosition(positionX, positionY);
            Entity newEntity = new(entityName, positionX, positionY);

            ListOfEntities.Add(newEntity);
        }
        return ListOfEntities;
    }

    public static void CreateFood() 
    {
        for (int i = 0; i < FOOD_COUNT; i++)
        {
            int positionY = Random.Next(0, GRID_HEIGHT);
            int positionX = Random.Next(0, GRID_WIDTH);

            Console.SetCursorPosition(positionX, positionY);
            Food newFood = new(positionX, positionY);

            Console.ForegroundColor = newFood.FoodColor;
            Console.Write(newFood.Character);
            Console.ResetColor();
        }
    }

    public static void DisplayControlVariables(int iteration) 
    {

        Console.SetCursorPosition(ITERATION_POSITION_X, 0);
        Console.WriteLine($"Iteration {iteration}");

        int entityIDCounter = -1;
        foreach (Entity entity in ListOfEntities)
        {
            entityIDCounter++;
            Console.SetCursorPosition(ENTITY_LIST_POSITION_X, entityIDCounter);
            Console.Write(entity.EntityName);
        }
    }
}