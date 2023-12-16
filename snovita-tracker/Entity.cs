using life;

internal class Entity
{
    public string EntityName;
    public string Character = "0";
    public int PositionX;
    public int PositionY;

    public Entity(string entityName, string character, int positionX, int positionY)
    {
        EntityName = entityName;
        Character = character;
        PositionX = positionX;
        PositionY = positionY;
    }

    public void Move()
    {
        int previousX = PositionX;
        int previousY = PositionY;

        Random random = new();
        int direction = random.Next(1, 5);

        switch (direction) 
        {
            case 1:
                PositionY = Math.Min(Program.GRID_HEIGHT - 1, PositionY + 1); // down
                break;

            case 2:
                PositionY = Math.Max(0, PositionY - 1); // up
                break;

            case 3:
                PositionX = Math.Min(Program.GRID_WIDTH - 1, PositionX + 1); // right
                break;

            case 4:
                PositionX = Math.Max(0, PositionX - 1); // left
                break;
        }

        Console.SetCursorPosition(previousX, previousY);
        Console.Write(Program.NODE);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(PositionX, PositionY);
        Console.Write(Character);
        Console.ResetColor();
    }
}
