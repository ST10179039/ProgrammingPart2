using ProgrammingPart2.ProgrammingPart2;
using ProgrammingPart2;

namespace ProgrammingPart2
{
    class Program
    {
        Ingredients sam;
        Utils s;
        StepsForRecipe n;
        Recipe f;
        List<string> recipeTitles;

        // Initialize instances in the constructor
        public Program()
        {
            recipeTitles = new List<string>();
            sam = new Ingredients(recipeTitles);  // Pass recipeTitles to Ingredients
            s = new Utils(this);
            n = new StepsForRecipe();
            f = new Recipe(this, recipeTitles);  // Pass recipeTitles to Recipe
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Please select your menu:"
                                 + "\n1. Enter Recipe"
                                 + "\n2. Scale Factor"
                                 + "\n3. Display Recipe"
                                 + "\n4. Reset Quantity"
                                 + "\n5. Clear Recipe"
                                 + "\n6. Display Alphabetically"
                                 + "\n7. Search Recipe Name"
                                 + "\n8. Total Calories"
                                 + "\n9. Exit Application");

                if (!int.TryParse(Console.ReadLine(), out int menu))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                    continue;
                }

                switch (menu)
                {
                    case 1:
                        sam.EnterRecipe();
                        break;
                    case 2:
                        sam.ScaleFactor();
                        break;
                    case 3:
                        sam.DisplayRecipe();
                        break;
                    case 4:
                        sam.ResetValues();
                        break;
                    case 5:
                        sam.ClearRecipe();
                        break;
                    case 6:
                        sam.DisplayAlphabetically();
                        break;
                    case 7:
                        f.SearchRecipeName();
                        break;
                    case 8:
                        s.TotalCalories();
                        break;
                    case 9:
                        sam.ExitApp();
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 9.");
                        break;
                }
                Console.WriteLine("---------------------------------");
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }
    }
}