namespace life;

class Grid
{
    const int GRID_X = 20;
    const int GRID_Y = 10;
    const char GRID_CHAR = '.';

    const int POPULATION = 10;

    static void Main() 
    {
        BuildGrid();
        PopulateGrid();
        Console.ReadKey();
    }

    static void BuildGrid()
    {
        for (int i = 0; i < GRID_Y; i++)
        {
            Console.Write(GRID_CHAR);

            for (int j = 0; j < GRID_X; j++)
            {
                Console.Write(GRID_CHAR);
            }
            Console.WriteLine();
        }
    }

    static void PopulateGrid() 
    {
        Random rnd = new();


        for (int i = 0; i < POPULATION; i++)
        {
            int randX = rnd.Next(GRID_X);
            int randY = rnd.Next(GRID_Y);

            Entity entity = new();

            Console.SetCursorPosition(randX, randY);
            Console.Write(entity.SYMBOL);
        }
    }
}