namespace snovita_tracker;

internal class Ingredient
{
    public string Name { get; set; }
    public double ServingSize { get; set; }
    public NutritionInfo Nutrition { get; set; }

    public Ingredient(string name, double servingSize, NutritionInfo nutrition)
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

        public NutritionInfo(double Protein, double Carbs, double Fats, double Sugars, double Saturates, double Fibre, double Salt, double Calories)
        {
            this.Protein = Protein;
            this.Carbs = Carbs;
            this.Fats = Fats;
            this.Sugars = Sugars;
            this.Saturates = Saturates;
            this.Fibre = Fibre;
            this.Salt = Salt;
            this.Calories = Calories;
        }
    }

    public static Ingredient FindIngredient(string ingredient)
    {
        List<Ingredient> ingredientList = new()
        {
            new Ingredient(
                "sultanas",
                30,
                new NutritionInfo(0.8, 20.8, 0.1, 20.8, 0, 0.6, 0.01, 89)
            ),
        };

        Ingredient foundIngredient = ingredientList.FirstOrDefault(i => i.Name == ingredient);

        if (foundIngredient is not null) return foundIngredient;
        throw new InvalidOperationException($"Ingredient '{ingredient}' not found.");
    }
}
