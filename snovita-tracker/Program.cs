using static snovita_tracker.Ingredient;

namespace snovita_tracker;

internal class Program
{
    static void Main() => GetIngredient();

    List<Ingredient> totalIngredients = new();

    public static void GetIngredient()
    {
        Console.Write("Enter grams: ");

        if (!int.TryParse(Console.ReadLine(), out int grams))
        {
            Console.WriteLine("Invalid input for grams. Please enter a valid integer.");
            return;
        }

        Console.Write("Enter ingredient: ");
        string? ingredient = Console.ReadLine();

        if (ingredient is not null) 
        {
            Ingredient foundIngredient = Ingredient.FindIngredient(ingredient);
            CalculateMacros(grams, foundIngredient, ingredient);

            Console.WriteLine("Enter another ingredient?");
            string enterAnotherIngredient = Console.ReadLine().ToLower().Trim();
            if (enterAnotherIngredient == "y") GetIngredient();
        } 

        else Console.WriteLine("Ingredient cannot be null.");
    }

    public static void CalculateMacros(double grams, Ingredient foundIngredient, string ingredient)
    {
        Console.WriteLine($"\nIngredient: {foundIngredient.Name}\n");

        double macroRatio = grams / foundIngredient.ServingSize;

        double newProtein = Math.Round(macroRatio * foundIngredient.Nutrition.Protein, 2);
        double newCarbs = Math.Round(macroRatio * foundIngredient.Nutrition.Carbs, 2);
        double newFats = Math.Round(macroRatio * foundIngredient.Nutrition.Fats, 2);
        double newSugars = Math.Round(macroRatio * foundIngredient.Nutrition.Sugars, 2);
        double newSaturates = Math.Round(macroRatio * foundIngredient.Nutrition.Saturates, 2);
        double newFibre = Math.Round(macroRatio * foundIngredient.Nutrition.Fibre, 2);
        double newSalt = Math.Round(macroRatio * foundIngredient.Nutrition.Salt, 2);
        double newCalories = Math.Round(macroRatio * foundIngredient.Nutrition.Calories, 2);

        NutritionInfo newNutritionInfo = new(newProtein, newCarbs, newFats, newSugars, newSaturates, newFibre, newSalt, newCalories);
        Ingredient newIngredient = new(ingredient, grams, newNutritionInfo);

        Console.WriteLine($"\nName: {newIngredient.Name}\nServing: {newIngredient.ServingSize}g\n\n\nNutrition:" +
            $"\n  - Protein".PadRight(20) + $"{newProtein}g" +
            $"\n  - Carbs".PadRight(20) + $"{newCarbs}g" +
            $"\n  - Fats".PadRight(20) + $"{newFats}g" +
            $"\n  - Sugars".PadRight(20) + $"{newSugars}g" +
            $"\n  - Saturates".PadRight(20) + $"{newSaturates}g" +
            $"\n  - Fibre".PadRight(20) + $"{newFibre}g" +
            $"\n  - Salt".PadRight(20) + $"{newSalt}g" +
            $"\n  - Calories".PadRight(20) + $"{newCalories}kcal");

    }


}
