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

    public void GenerateFood()
    {
        Random random = new();
        int attempts = 0;

        do
        {
            int clusterX = PositionX;
            int clusterY = PositionY;

            int positionX = random.Next(clusterX - 2, clusterX + 3);
            int positionY = random.Next(clusterY - 2, clusterY + 3);

            if (positionX >= 0 && positionX < Program.GRID_WIDTH &&
                positionY >= 0 && positionY < Program.GRID_HEIGHT &&
                !Program.ListOfFoodClusters.Any(cluster => Math.Abs(cluster.PositionX - positionX) < 2 && Math.Abs(cluster.PositionY - positionY) < 2))
            {
                Console.SetCursorPosition(positionX, positionY);
                Food newFood = new(positionX, positionY);
                Program.ListOfFood.Add(newFood);

                Console.ForegroundColor = newFood.FoodColor;
                Console.Write(newFood.Character);
                Console.ResetColor();

                return;
            }

            attempts++;

        } while (attempts < 100);
    }

}