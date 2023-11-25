namespace snovita_tracker;

internal class Program
{
    static void Main() => Starter();

    public static void Starter()
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
            Ingredient foundIngredient = Ingredient.GetIngredient(grams, ingredient);
            CalculateMacros(grams, foundIngredient);
        } 

        else Console.WriteLine("Ingredient cannot be null.");
    }

    public static void CalculateMacros(int grams, Ingredient ingredient) 
    {
        Console.WriteLine(ingredient.Name);
    }
}
