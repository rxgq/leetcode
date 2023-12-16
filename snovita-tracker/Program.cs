namespace life;

internal class Program
{
    public const int GRID_WIDTH = 16;
    public const int GRID_HEIGHT = 8;
    public const string NODE = ".";
    public const int SIMULATION_SPEED_MS = 100;
    public const int ENTITY_COUNT = 2;
    public const int FOOD_COUNT = 40;
    public const int ENTITY_LIST_POSITION_X = 80;
    public const int ITERATION_POSITION_X = GRID_WIDTH + 1;

    public static readonly List<Entity> ListOfEntities = new();
    public static readonly List<Food> ListOfFood = new();

    public static Random Random = new();

    static void Main() => BuildSimulation();

    public static void BuildSimulation()
    {
        BuildNodes();
        CreateEntities();
        CreateFood();

        int iteration = -1;

        while (true)
        {
            iteration++;

            Thread.Sleep(SIMULATION_SPEED_MS);

            if (ListOfEntities.Count == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(ITERATION_POSITION_X, 0);
                Console.Write($"All entities are dead. Final Iteration: {iteration}");
                Console.ReadKey();
                return;
            }

            List<Entity> entitiesToRemove = new List<Entity>();
            DisplayControlVariables(iteration);

            foreach (Entity entity in ListOfEntities.ToList())
            {

                entity.IterationsUntilDeath--;

                if (entity.IterationsUntilDeath == 0)
                {
                    entitiesToRemove.Add(entity);

                    Console.SetCursorPosition(entity.PositionX, entity.PositionY);
                    Console.Write(NODE);
                }

                if (entity.CollectedFood.Count > 1)
                {
                    entity.Reproduce();
                }

                if (entity.CollectedFood.Count > 0 && entity.IterationsUntilDeath == 1)
                {
                    entity.ConsumeFood();
                }

                entity.Move();
            }

            foreach (Entity entityToRemove in entitiesToRemove)
            {
                ListOfEntities.Remove(entityToRemove);
                Console.SetCursorPosition(entityToRemove.PositionX, entityToRemove.PositionY);
                Console.Write(NODE);
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
            string entityName = $"Entity {entityID}";

            int positionX, positionY;
            do
            {
                positionY = Random.Next(0, GRID_HEIGHT);
                positionX = Random.Next(0, GRID_WIDTH);
            } while (ListOfEntities.Any(entity => entity.PositionX == positionX && entity.PositionY == positionY));

            Console.SetCursorPosition(positionX, positionY);
            Entity newEntity = new(entityName, positionX, positionY);

            ListOfEntities.Add(newEntity);
            entityID++;
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
            ListOfFood.Add(newFood);

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
            Console.Write($"{entity.EntityName} | Food: {entity.CollectedFood.Count} | Health: {entity.IterationsUntilDeath} ");
        }
    }
}