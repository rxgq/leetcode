namespace life;

internal class FoodCluster
{
    public string Character = "C";
    public ConsoleColor FoodColor = ConsoleColor.Cyan;
    public int PositionX;
    public int PositionY;

    public FoodCluster(int positionX, int positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
    }

    public static void GenerateFood() 
    { 
        
    }
}