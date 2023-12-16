namespace life;

internal class Program
{
    const int GRID_WIDTH = 24;
    const int GRID_HEIGHT = 12;
    const string NODE = ".";
    const string ENTITY = "0";

    static void Main()
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
        
        CreateEntity();
    }

    public static void CreateEntity() 
    {
        Random random = new();
        int positionX = random.Next(0, GRID_HEIGHT);
        int positionY = random.Next(0, GRID_WIDTH);

        Console.SetCursorPosition(positionY, positionX);
        Console.WriteLine(ENTITY);
    }
}
