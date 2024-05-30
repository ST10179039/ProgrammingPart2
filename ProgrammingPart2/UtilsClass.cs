using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingPart2;

namespace ProgrammingPart2
{
    delegate int CalculateTotalDelegate<T>(T cal);

    internal class Utils
    {
        private List<int> NumberOfCalories = new List<int>();
        Program maybe;

        // Constructor to accept a Program instance to prevent creating new instances
        public Utils(Program program)
        {
            maybe = program;
        }

        public void AddCalories(int calories)
        {
            NumberOfCalories.Add(calories);
        }

        public void TotalCalories() // This method calculates the total calories using delegates
        {
            // Create an instance of the delegate
            CalculateTotalDelegate<int> calculateCalories = Calories;

            // Invoke the delegate to calculate the total
            int total = CalculateNumCalories(NumberOfCalories, calculateCalories);

            if (total <= 300)
            {
                Console.WriteLine("Total Calories: " + total);
            }
            else
            {
                Console.WriteLine("You have exceeded your total calories."
                                  + " Exceeding caloric needs by 300 calories per day can result in a weight "
                                  + "gain of approximately 0.1 kilograms (0.22 pounds) per week.");
            }

            // Return to menu or exit
            maybe.Menu();
        }

        // Method to calculate total calories using the delegate
        private int CalculateNumCalories(IEnumerable<int> numberOfCalories, CalculateTotalDelegate<int> calculateCalories)
        {
            int total = 0;

            foreach (int item in numberOfCalories)
            {
                total += calculateCalories(item);
            }

            return total;
        }

        // Method to return the calories, used by the delegate
        public int Calories(int numCalories)
        {
            return numCalories;
        }
    }
}