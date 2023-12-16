namespace life;

internal class Entity
{
    public string EntityName;
    public string Character = "0";
    public ConsoleColor EntityColour = ConsoleColor.Green;

    public int PositionX;
    public int PositionY;
    public int IterationsUntilDeath = 20;

    public List<Food> CollectedFood = new();
    

    public Entity(string entityName, int positionX, int positionY)
    {
        EntityName = entityName;
        PositionX = positionX;
        PositionY = positionY;
    }

    public void Move()
    {
        int previousX = PositionX;
        int previousY = PositionY;

        Random random = new();
        int direction = random.Next(1, 5);

        int newPosX = PositionX;
        int newPosY = PositionY;

        switch (direction)
        {
            case 1:
                newPosY = Math.Min(Program.GRID_HEIGHT - 1, PositionY + 1); // down
                break;

            case 2:
                newPosY = Math.Max(0, PositionY - 1); // up
                break;

            case 3:
                newPosX = Math.Min(Program.GRID_WIDTH - 1, PositionX + 1); // right
                break;

            case 4:
                newPosX = Math.Max(0, PositionX - 1); // left
                break;
        }

        if (!EntityAtPosition(newPosX, newPosY))
        {
            Console.SetCursorPosition(previousX, previousY);
            Console.Write(Program.NODE);

            if (FoodAtPosition(newPosX, newPosY))
            {
                Console.SetCursorPosition(newPosX, newPosY);
            }

            Console.ForegroundColor = EntityColour;
            Console.SetCursorPosition(newPosX, newPosY);
            Console.Write(Character);
            Console.ResetColor();

            PositionX = newPosX;
            PositionY = newPosY;
        }
    }


    private bool FoodAtPosition(int positionX, int positionY)
    {
        Food foodToRemove = null;

        foreach (Food food in Program.ListOfFood)
        {
            if (food.PositionX == positionX && food.PositionY == positionY)
            {
                foodToRemove = food;
                break;
            }
        }

        if (foodToRemove != null)
        {
            Program.ListOfFood.Remove(foodToRemove);
            CollectedFood.Add(foodToRemove);
            return true;
        }

        return false;
    }


    public bool EntityAtPosition(int positionX, int positionY) 
    {
        foreach (Entity entity in Program.ListOfEntities)
        {
            if (entity.PositionX == positionX && entity.PositionY == positionY)
            {
                return true;
            }
        }
        return false;
    }

    public void ConsumeFood() 
    {
        if (CollectedFood.Count > 0) 
        {
            CollectedFood.RemoveAt(0);
            IterationsUntilDeath = 20;
        }
    }
}

