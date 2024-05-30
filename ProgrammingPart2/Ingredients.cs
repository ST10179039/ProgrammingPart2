using ProgrammingPart2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPart2
{
    internal class Ingredients
    {
        private List<string> RecipeTitle;
        private List<int> Quantities = new List<int>();
        private List<string> UnitsOfMeasurement = new List<string>();
        private List<int> Calories = new List<int>();
        private List<string> FoodGroups = new List<string>();
        private List<List<string>> StepDescriptions = new List<List<string>>();
        private List<int> StepCounts = new List<int>(); // Corrected declaration

        public Ingredients(List<string> recipeTitle)
        {
            RecipeTitle = recipeTitle;
        }

        public void EnterRecipe()
        {
            Console.WriteLine("Please enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine("Please enter the name of your recipe:");
                string currentRecipeTitle = Console.ReadLine();
                RecipeTitle.Add(currentRecipeTitle);

                Console.WriteLine("Please enter the quantity of your ingredient:");
                int quantity = int.Parse(Console.ReadLine());
                Quantities.Add(quantity);

                Console.WriteLine("Please enter your unit of measurement:");
                string unitOfMeasurement = Console.ReadLine();
                UnitsOfMeasurement.Add(unitOfMeasurement);

                Console.WriteLine("Please enter the number of calories:");
                int calories = int.Parse(Console.ReadLine());
                Calories.Add(calories);
                totalCalories += calories;

                Console.WriteLine("Please select the food group for your ingredient:"
                                + "\n1. Carbohydrates"
                                + "\n2. Proteins"
                                + "\n3. Fats"
                                + "\n4. Water"
                                + "\n5. Vitamins and minerals"
                                + "\n6. Dairy products"
                                + "\n7. Vegetables and fruits");
                int foodGroupOption = int.Parse(Console.ReadLine());

                string foodGroup = foodGroupOption switch
                {
                    1 => "Carbohydrates",
                    2 => "Proteins",
                    3 => "Fats",
                    4 => "Water",
                    5 => "Vitamins and minerals",
                    6 => "Dairy products",
                    7 => "Vegetables and fruits",
                    _ => "Unknown"
                };
                FoodGroups.Add(foodGroup);

                Console.WriteLine("Please enter the number of steps:");
                int numberOfSteps = int.Parse(Console.ReadLine());
                StepCounts.Add(numberOfSteps);

                List<string> steps = new List<string>();
                for (int j = 0; j < numberOfSteps; j++)
                {
                    Console.WriteLine($"Please enter the description of step {j + 1}:");
                    string stepDescription = Console.ReadLine();
                    steps.Add(stepDescription);
                }
                StepDescriptions.Add(steps);
            }

            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: Total calories of the recipe exceed 300!");
            }
        }


        public void DisplayRecipe()
        {
            for (int i = 0; i < RecipeTitle.Count; i++)
            {
                Console.WriteLine($"Recipe: {RecipeTitle[i]}");
                Console.WriteLine($"Quantity: {Quantities[i]} {UnitsOfMeasurement[i]}");
                Console.WriteLine($"Calories per Serving: {Calories[i]}"); // Adding calories
                Console.WriteLine($"Number of Steps: {StepCounts[i]}");

                for (int j = 0; j < StepDescriptions[i].Count; j++)
                {
                    Console.WriteLine($"Step {j + 1}: {StepDescriptions[i][j]}");
                }

                Console.WriteLine("---------------------------------");
            }
        }

        public void ResetValues()
        {
            Console.WriteLine("Do you want to reset the values?"
                              + "\n1. Yes"
                              + "\n2. No");
            int resetValue = int.Parse(Console.ReadLine());

            if (resetValue == 1)
            {
                RecipeTitle.Clear();
                Quantities.Clear();
                UnitsOfMeasurement.Clear();
                StepCounts.Clear();
                StepDescriptions.Clear();
                Console.WriteLine("Values have been reset.");
            }
            else if (resetValue == 2)
            {
                Console.WriteLine("End");
            }
        }

        public void ScaleFactor()
        {
            Console.WriteLine("Please select a scale factor:"
                              + "\n1. 0.5 (half)"
                              + "\n2. 2 (double)"
                              + "\n3. 3 (triple)");
            int scaleOption = int.Parse(Console.ReadLine());

            double scaleFactor = scaleOption switch
            {
                1 => 0.5,
                2 => 2,
                3 => 3,
                _ => 1
            };

            Console.WriteLine("Scaled Quantities:");
            for (int i = 0; i < Quantities.Count; i++)
            {
                double originalQuantity = Quantities[i];
                double scaledQuantity = originalQuantity * scaleFactor;
                Quantities[i] = (int)scaledQuantity;
                Console.WriteLine($"Ingredient {i + 1}: Original Quantity = {originalQuantity}, Scaled Quantity = {scaledQuantity} {UnitsOfMeasurement[i]}");
            }
        }

        public void ClearRecipe()
        {
            Console.WriteLine("Are you sure you want to clear all data and start a new recipe?"
                            + "\n1. Yes"
                            + "\n2. No");
            int confirmation = int.Parse(Console.ReadLine());

            if (confirmation == 1)
            {
                RecipeTitle.Clear();
                Quantities.Clear();
                UnitsOfMeasurement.Clear();
                StepCounts.Clear();
                StepDescriptions.Clear();
                Console.WriteLine("Your data has been successfully cleared!");
            }
        }

        public void DisplayAlphabetically()
        {
            RecipeTitle.Sort();
            Console.WriteLine("Recipes displayed alphabetically below:");

            foreach (string recipe in RecipeTitle)
            {
                Console.WriteLine(recipe);
            }
        }

        public void ExitApp()
        {
            Console.WriteLine("We enjoyed having you, thank you for using our app");
            Environment.Exit(0); // Exit the application
        }
    }
}