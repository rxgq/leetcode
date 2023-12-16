namespace life;

internal class Program
{
    const int GRID_WIDTH = 24;
    const int GRID_HEIGHT = 12;
    const string NODE = ".";

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
    }
}
