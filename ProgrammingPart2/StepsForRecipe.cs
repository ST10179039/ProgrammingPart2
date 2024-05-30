using ProgrammingPart2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPart2
{
    internal class StepsForRecipe
    {
        int noOfSteps;
        List<string> StepDescriptions = new List<string>();

        public void RecipeStep()
        {
            Console.WriteLine("*****************************************");

            Console.WriteLine("Please enter the number of your steps:");
            if (!int.TryParse(Console.ReadLine(), out noOfSteps) || noOfSteps <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the steps.");
                return;
            }

            // Loop for the number of steps the user is going to input
            for (int m = 0; m < noOfSteps; m++)
            {
                Console.WriteLine("Please enter the description of your step {0}:", m + 1);
                string description = Console.ReadLine();
                StepDescriptions.Add(description);
            }

            Console.WriteLine("Steps have been recorded successfully.");
        }

        public void DisplaySteps()
        {
            Console.WriteLine("Steps for the recipe:");
            for (int i = 0; i < StepDescriptions.Count; i++)
            {
                Console.WriteLine("Step {0}: {1}", i + 1, StepDescriptions[i]);
            }
        }
    }
}