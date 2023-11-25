namespace snovita_tracker;

internal class Ingredient
{
    public string Name { get; set; }
    public int ServingSize { get; set; }
    public NutritionInfo Nutrition { get; set; }

    public Ingredient(string name, int servingSize, NutritionInfo nutrition)
    {
        Name = name;
        ServingSize = servingSize;
        Nutrition = nutrition;
    }

    public class NutritionInfo
    {
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Sugars { get; set; }
        public double Saturates { get; set; }
        public double Fibre { get; set; }
        public double Salt { get; set; }
        public double Calories { get; set; }
    }

    public static Ingredient GetIngredient(int grams, string ingredient)
    {
        List<Ingredient> ingredientList = new()
        {
            new Ingredient(
                "sultanas",
                30,
                new NutritionInfo
                {
                    Protein = 0.8,
                    Carbs = 20.8,
                    Fats = 0.1,
                    Sugars = 20.8,
                    Saturates = 0,
                    Fibre = 0.6,
                    Salt = 0.01,
                    Calories = 89
                }
            ),
        };

        Ingredient foundIngredient = ingredientList.FirstOrDefault(i => i.Name == ingredient);

        if (foundIngredient is not null) return foundIngredient;
        throw new InvalidOperationException($"Ingredient '{ingredient}' not found.");
    }
}
