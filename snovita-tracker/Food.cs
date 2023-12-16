namespace life;

internal class Food
{
    public string Character = "F";
    public ConsoleColor FoodColor = ConsoleColor.Green;
    public int PositionX;
    public int PositionY;

    public Food(int positionX, int positionY) 
    {
        PositionX = positionX;
        PositionY = positionY;
    }
}

