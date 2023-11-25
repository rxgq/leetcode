using static snovita_tracker.Ingredient;

namespace snovita_tracker;

internal class Program
{
    static void Main() => GetIngredient();

    static List<Ingredient> TotalIngredients = new();

    public static void GetIngredient()
    {
        Console.Clear();

        double grams;

        while (true)
        {
            Console.Write("Enter serving size (g): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out grams)) break;
            else 
            { 
                Console.WriteLine("\n\tInvalid input. Please enter a valid numeric value for grams.\n\tPlease press enter."); 
                Console.ReadKey(); Console.Clear();
            }
        }

        Console.Write("\nEnter ingredient name: ");
        string? ingredient = Console.ReadLine();

        if (ingredient is not null) 
        {
            Ingredient foundIngredient = FindIngredient(ingredient);

            if (foundIngredient is null) GetIngredient();

            else
            {
                CalculateMacros(grams, foundIngredient, ingredient);

                Console.WriteLine("\nEnter another ingredient? (y/n)");
                string enterAnotherIngredient = Console.ReadLine().ToLower().Trim();
                if (enterAnotherIngredient == "y")
                    GetIngredient();
                else
                    OutputIngredients();
            }

        }

        else Console.WriteLine("\n\tIngredient cannot be null.");
    }

    public static void CalculateMacros(double grams, Ingredient foundIngredient, string ingredient)
    {
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
        TotalIngredients.Add(newIngredient);

        Console.Clear();

        Console.WriteLine($"Name: {newIngredient.Name}\nServing: {newIngredient.ServingSize}g\n\nNutrition:" +
            $"\n  - Protein".PadRight(20) + $"{newProtein}g" +
            $"\n  - Carbs".PadRight(20) + $"{newCarbs}g" +
            $"\n  - Fats".PadRight(20) + $"{newFats}g" +
            $"\n  - Sugars".PadRight(20) + $"{newSugars}g" +
            $"\n  - Saturates".PadRight(20) + $"{newSaturates}g" +
            $"\n  - Fibre".PadRight(20) + $"{newFibre}g" +
            $"\n  - Salt".PadRight(20) + $"{newSalt}g" +
            $"\n  - Calories".PadRight(20) + $"{newCalories}kcal\n\nThis has been added to your total ingredients list.\nCurrently holding: {TotalIngredients.Count}(s)");
    }

    public static void OutputIngredients() 
    {
        Console.Clear();
        foreach (var ingredient in TotalIngredients) 
        {
            Console.WriteLine($"\nName: {ingredient.Name}\nServing: {ingredient.ServingSize}g\n\n\nNutrition:" +
                $"\n  - Protein".PadRight(20) + $"{ingredient.Nutrition.Protein}g" +
                $"\n  - Carbs".PadRight(20) + $"{ingredient.Nutrition.Carbs}g" +
                $"\n  - Fats".PadRight(20) + $"{ingredient.Nutrition.Fats}g" +
                $"\n  - Sugars".PadRight(20) + $"{ingredient.Nutrition.Sugars}g" +
                $"\n  - Saturates".PadRight(20) + $"{ingredient.Nutrition.Saturates}g" +
                $"\n  - Fibre".PadRight(20) + $"{ingredient.Nutrition.Fibre}g" +
                $"\n  - Salt".PadRight(20) + $"{ingredient.Nutrition.Salt}g" +
                $"\n  - Calories".PadRight(20) + $"{ingredient.Nutrition.Calories}kcal\n\n\n");
        }
        Console.WriteLine("Your total ingredients are listed above.");
        OutputTotalMacros();
    }

    public static void OutputTotalMacros()
    {
        double totalProtein = 0;
        double totalCarbs = 0;
        double totalFats = 0;
        double totalSugars = 0;
        double totalSaturates = 0;
        double totalFibre = 0;
        double totalSalt = 0;
        double totalCalories = 0;

        foreach (var ingredient in TotalIngredients)
        {
            totalProtein += ingredient.Nutrition.Protein;
            totalCarbs += ingredient.Nutrition.Carbs;
            totalFats += ingredient.Nutrition.Fats;
            totalSugars += ingredient.Nutrition.Sugars;
            totalSaturates += ingredient.Nutrition.Saturates;
            totalFibre += ingredient.Nutrition.Fibre;
            totalSalt += ingredient.Nutrition.Salt;
            totalCalories += ingredient.Nutrition.Calories;
        }

        Console.WriteLine("\n\n\nTotal Macros for All Ingredients:\n" +
            $"\n  - Protein".PadRight(20) + $"{Math.Round(totalProtein, 2)}g" +
            $"\n  - Carbs".PadRight(20) + $"{Math.Round(totalCarbs, 2)}g" +
            $"\n  - Fats".PadRight(20) + $"{Math.Round(totalFats, 2)}g" +
            $"\n  - Sugars".PadRight(20) + $"{Math.Round(totalSugars, 2)}g" +
            $"\n  - Saturates".PadRight(20) + $"{Math.Round(totalSaturates, 2)}g" +
            $"\n  - Fibre".PadRight(20) + $"{Math.Round(totalFibre, 2)}g" +
            $"\n  - Salt".PadRight(20) + $"{Math.Round(totalSalt, 2)}g" +
            $"\n  - Calories".PadRight(20) + $"{Math.Round(totalCalories, 2)}kcal\n\n\n");
    }

}
