namespace life;

class Grid
{
    public const int X = 30;
    public const int Y = 15;
    public const char NODE = '.';
    public const int ITERATIONS_UNTIL_DEATH = 10;
    
    const int SIMULATION_SPEED_MS = 0;
    const int POPULATION = 1;
    static int FoodPerIteration = 8; 
    
    static int Iteration = 0;
    public static int EntityDeaths = 0;
    public static int FoodSpawned = 0;
    public static int AverageEntites = 0;
    public static int MaxEntities = 0;

    public static int TotalEntites = 0;

    static bool IsExtinct = false;
    static bool ForcedExtinction = false;

    public static ConsoleColor COLOUR = ConsoleColor.White;  

    public static List<Entity> Population = new();
    public static List<Food> FoodList = new();

    static readonly Random rnd = new();


    static void Main() 
    {
        BuildGrid();
        PopulateGrid();

        Task.Run(() => ListenForKeyCommands());

        while (true)
        {
            DisplayControlVariables();
            Iterate();

            Iteration++;
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

    static void DisplayControlVariables()
    {
        Console.ForegroundColor = COLOUR;

        string[] variables = new string[]
        {
            $"Iteration:           {Iteration}",
            $"Entity Count:        {Population.Count}",
            $"Entity Deaths:       {EntityDeaths}",
            $"Food Spawned:        {FoodSpawned}",
            $"Max Entities:        {MaxEntities}",
            $"Average Entities:    {AverageEntites}",
            $"Food Spawn Rate:     {FoodPerIteration}"
        };

        for (int i = 0; i < variables.Length; i++)
        {
            Console.ForegroundColor = variables[i].Contains(
                "Iteration") ? ConsoleColor.White : variables[i].Contains(
                "Count") ? Entity.COLOUR : variables[i].Contains(
                "Deaths") ? ConsoleColor.Red : variables[i].Contains(
                "Food Spawned") ? Food.COLOUR : ConsoleColor.DarkGray;

            Console.SetCursorPosition(X + 2, i);
            Console.Write(new string(' ', Console.WindowWidth - (X + 2)));

            Console.SetCursorPosition(X + 2, i);
            Console.Write(variables[i]);

            Console.ResetColor();
        }
    }

    static void Iterate()
    {
        GenerateFood();
        RemoveDeadEntities();

        var populationCopy = new List<Entity>(Population);

        foreach (var entity in populationCopy)
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

        UpdateAverageAndMaxEntities();
        CheckIfExtinct();

        Thread.Sleep(SIMULATION_SPEED_MS);
    }


    static void RemoveDeadEntities() 
    {
        var entitiesToRemove = Population.Where(entity => entity.IterationsUntilDeath == 0 && entity.FoodCount == 0).ToList();

        foreach (var entity in entitiesToRemove)
        {
            Population.Remove(entity);
            EntityDeaths++;

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(entity.X, entity.Y);
            Console.Write(NODE);
        }
    }

    static void GenerateFood()
    {
        var foodListCopy = new List<Food>(FoodList);

        for (int i = 0; i < FoodPerIteration; i++)
        {
            int randX = rnd.Next(X), randY = rnd.Next(Y);

            if (Population.Any(entity => entity.X == randX && entity.Y == randY) ||
                foodListCopy.Any(food => food.X == randX && food.Y == randY))
            {
                continue;
            }

            FoodSpawned++;
            Food food = new(randX, randY);
            FoodList.Add(food);

            Console.ForegroundColor = Food.COLOUR;

            Console.SetCursorPosition(randX, randY);
            Console.Write(Food.SYMBOL);
        }
    }


    static void UpdateAverageAndMaxEntities() 
    {
        TotalEntites += Population.Count;

        if (Iteration is not 0)
        {
            AverageEntites = TotalEntites / Iteration;
        }

        if (Population.Count > MaxEntities)
        {
            MaxEntities = Population.Count;
        }
    }

    static void CheckIfExtinct() 
    {
        if (!IsExtinct && Population.Count is 0)
        {
            int extinctionIteration = Iteration;
            IsExtinct = true;

            Console.SetCursorPosition(X + 2, 8);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{(ForcedExtinction ? "Forced " : "")}Extinction at Iteration: {extinctionIteration}");
        }
    }

    static void ListenForKeyCommands()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F)
                {
                    ForcedExtinction = true;
                    int tempFoodPerIteration = FoodPerIteration;
                    FoodPerIteration = 0;
                    Thread.Sleep(1000);
                    FoodPerIteration = tempFoodPerIteration;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    FoodPerIteration++;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    FoodPerIteration--;
                }
                else if (key == ConsoleKey.R)
                {
                    RestartSimulation();
                }
            }

            Thread.Sleep(100);
        }
    }

    static void RestartSimulation()
    {
        FoodPerIteration = 8;
        Iteration = 0;
        EntityDeaths = 0;
        FoodSpawned = 0;
        AverageEntites = 0;
        MaxEntities = 0;
        TotalEntites = 0;
        IsExtinct = false;
        ForcedExtinction = false;

        Population.Clear();
        FoodList.Clear();

        Console.Clear();
        BuildGrid();
        PopulateGrid();
    }
}