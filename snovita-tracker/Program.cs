namespace life;

internal class Program
{
    public const int GRID_WIDTH = 32;
    public const int GRID_HEIGHT = 16;
    public const string NODE = ".";
    public const int SIMULATION_SPEED_MS = 50;
    public const int ITERATION_POSITION_X = GRID_WIDTH + 1;

    public const int ENTITY_COUNT = 0;
    public const int FOOD_PATTERN_GENE_ENTITY_COUNT = 1;

    public const int FOOD_COUNT_PER_ITERATION = 1;
    public const int FOOD_CLUSTERS = 5;

    public static readonly List<Entity> ListOfEntities = new();
    public static readonly List<Food> ListOfFood = new();
    public static readonly List<FoodCluster> ListOfFoodClusters = new();

    public static Random Random = new();

    public static double averageEntityCount = 0;
    public static int highestEntityCount = 0;

    static void Main() => BuildSimulation();

    public static void BuildSimulation()
    {
        BuildNodes();
        CreateEntities();
        CreateFood();
        CreateFoodClusters();

        int iteration = -1;

        while (true)
        {
            CreateFood();
            iteration++;

            if (ListOfEntities.Count > highestEntityCount) 
            { 
                highestEntityCount = ListOfEntities.Count;
            }

            averageEntityCount += ListOfEntities.Count;

           Thread.Sleep(SIMULATION_SPEED_MS);

/*            if (ListOfEntities.Count == 0)
            {
                Console.Clear();
                Console.Write($"All entities are dead. Final Iteration: {iteration}");
                Console.ReadKey();
                return;
            }*/

            List<Entity> entitiesToRemove = new();
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
        for (int i = 0; i < ENTITY_COUNT; i++)
        {
            int positionX, positionY;
            do
            {
                positionY = Random.Next(0, GRID_HEIGHT);
                positionX = Random.Next(0, GRID_WIDTH);
            } while (ListOfEntities.Any(entity => entity.PositionX == positionX && entity.PositionY == positionY));

            Console.SetCursorPosition(positionX, positionY);
            Entity newEntity = new(positionX, positionY, false, ConsoleColor.Yellow);

            ListOfEntities.Add(newEntity);
        }

        for (int i = 0; i < FOOD_PATTERN_GENE_ENTITY_COUNT; i++)
        {
            int positionX, positionY;
            do
            {
                positionY = Random.Next(0, GRID_HEIGHT);
                positionX = Random.Next(0, GRID_WIDTH);
            } while (ListOfEntities.Any(entity => entity.PositionX == positionX && entity.PositionY == positionY));

            Console.SetCursorPosition(positionX, positionY);
            Entity newEntity = new(positionX, positionY, true, ConsoleColor.Red);

            ListOfEntities.Add(newEntity);
        }
        return ListOfEntities;
    }

    public static void CreateFood()
    {
        for (int i = 0; i < FOOD_COUNT_PER_ITERATION; i++)
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

    public static void CreateFoodClusters() 
    {
        for (int i = 0; i < FOOD_CLUSTERS; i++)
        {
            int positionY = Random.Next(0, GRID_HEIGHT);
            int positionX = Random.Next(0, GRID_WIDTH);

            Console.SetCursorPosition(positionX, positionY);
            FoodCluster newFoodCluster = new(positionX, positionY);
            ListOfFoodClusters.Add(newFoodCluster);

            Console.ForegroundColor = newFoodCluster.FoodColor;
            Console.Write(newFoodCluster.Character);
            Console.ResetColor();
        }
    }

    public static void DisplayControlVariables(int iteration) 
    {

        Console.SetCursorPosition(ITERATION_POSITION_X, 0);
        Console.WriteLine($"Iteration        {iteration} ");

        Console.SetCursorPosition(ITERATION_POSITION_X, 2);
        Console.WriteLine($"Entity Count     {ListOfEntities.Count} ");

        Console.SetCursorPosition(ITERATION_POSITION_X, 3);
        Console.WriteLine($"Max Entities     {highestEntityCount} ");

        Console.SetCursorPosition(ITERATION_POSITION_X, 4);
        Console.WriteLine($"Average Entities {Math.Round((double)averageEntityCount / iteration, 2)} ");
    }
}