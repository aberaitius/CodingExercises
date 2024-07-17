using System;

namespace HackerRankProject
{
     class Program
    {
        public static void Main(string[] args)
        {
            // You can use this space to manually run and test your function.
            // Example:
            int steps = 8;
            string path = "UDDDUDUU";
            int result = countingValleys(steps, path);
            Console.WriteLine($"Number of valleys: {result}");

            // Run test cases
            RunTests();
        }

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int numberOfValleys = 0; // To count the number of valleys
            int altitude = 0;        // To track the current altitude
            bool inValley = false;   // To check if the hiker is currently in a valley

            foreach (char step in path)
            {
                if (step == 'U')
                {
                    altitude++; // Increment altitude for 'U' step
                    if (altitude == 0 && inValley)
                    {
                        // When returning to sea level from a valley
                        numberOfValleys++;
                        inValley = false; // Reset the valley flag
                    }
                }
                else if (step == 'D')
                {
                    altitude--; // Decrement altitude for 'D' step
                    if (altitude < 0 && !inValley)
                    {
                        // When going below sea level and not already in a valley
                        inValley = true; // Set the valley flag
                    }
                }
            }

            return numberOfValleys;
        }

        public static void RunTests()
        {
            // Test case 1
            int steps1 = 8;
            string path1 = "UDDDUDUU";
            int expected1 = 1;
            int result1 = countingValleys(steps1, path1);
            Console.WriteLine($"Test Case 1: {(result1 == expected1 ? "Passed" : "Failed")} (Expected: {expected1}, Got: {result1})");

            // Test case 2
            int steps2 = 12;
            string path2 = "DDUUDDUDUUUD";
            int expected2 = 2;
            int result2 = countingValleys(steps2, path2);
            Console.WriteLine($"Test Case 2: {(result2 == expected2 ? "Passed" : "Failed")} (Expected: {expected2}, Got: {result2})");

            // Add more test cases as needed
        }
    }
}
