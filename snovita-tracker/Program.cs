namespace life;

class Grid
{
    public const int X = 30;
    public const int Y = 15;
    public const char NODE = '.';
    public const int ITERATIONS_UNTIL_DEATH = 10;
    
    const int SIMULATION_SPEED_MS = 0;
    const int POPULATION = 1;
    static int FOOD_PER_ITERATION = 8;

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

    static int Iteration = 0;

    static void Main() 
    {
        BuildGrid();
        PopulateGrid();
        Task.Run(() => ListenForKeyPress());

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
        $"Iteration:         {Iteration}",
        $"Entity Count:        {Population.Count}",
        $"Entity Deaths:       {EntityDeaths}",
        $"Food Spawned:        {FoodSpawned}",
        $"Max Entities:        {MaxEntities}",
        $"Average Entities:    {AverageEntites}",
        };

        for (int i = 0; i < variables.Length; i++)
        {
            Console.ForegroundColor = variables[i].Contains(
                "Iteration") ? ConsoleColor.White : variables[i].Contains(
                "Count") ? Entity.COLOUR : variables[i].Contains(
                "Deaths") ? ConsoleColor.Red : variables[i].Contains(
                "Food") ? Food.COLOUR : ConsoleColor.DarkGray;

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
        for (int i = 0; i < FOOD_PER_ITERATION; i++) 
        {
            int randX = rnd.Next(X), randY = rnd.Next(Y);

            if (Population.Any(entity => entity.X == randX && entity.Y == randY) ||
                FoodList.Any(food => food.X == randX && food.Y == randY))
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

            Console.SetCursorPosition(X + 2, 7);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{(ForcedExtinction ? "Forced " : "")}Extinction at Iteration: {extinctionIteration}");

            Console.ReadKey();
        }
    }

    static void ListenForKeyPress()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F)
                {
                    ForcedExtinction = true;
                    FOOD_PER_ITERATION = 0;
                }
                else if (key == ConsoleKey.UpArrow) 
                {
                    FOOD_PER_ITERATION++;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    FOOD_PER_ITERATION--;
                }
            }

            Thread.Sleep(100);
        }
    }
}