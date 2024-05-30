using ProgrammingPart2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingPart2
{
    namespace ProgrammingPart2
    {
        internal class Recipe
        {
            private List<string> RecipeTitle;
            private Program program; // Reference to the main Program class

            // Constructor accepts a Program instance to maintain the relationship
            public Recipe(Program program, List<string> recipeTitle)
            {
                this.program = program;
                RecipeTitle = recipeTitle;
            }

            public void SearchRecipeName()
            {
                // Prompts user to enter the name they are looking for
                Console.WriteLine("Enter the name of the recipe you are searching for:");
                string search = Console.ReadLine();

                // Check if the recipe name exists in the RecipeTitle list
                if (RecipeTitle.Contains(search))
                {
                    Console.WriteLine("Recipe found: " + search);
                }
                else
                {
                    // If the recipe name is not found, prompt the user to re-search or exit
                    Console.WriteLine("Recipe Name not found.");
                    Console.WriteLine("Would you like to return to menu or exit app?"
                                    + "\n1. Return to menu "
                                    + "\n2. Exit App ");

                    if (!int.TryParse(Console.ReadLine(), out int returnOption) || (returnOption != 1 && returnOption != 2))
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                        return;
                    }

                    switch (returnOption)
                    {
                        case 1:
                            // Call the Menu method from the Program class
                            program.Menu();
                            break;
                        case 2:
                            // Exit the application
                            Console.WriteLine("We enjoyed having you, thank you for using our app.");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}