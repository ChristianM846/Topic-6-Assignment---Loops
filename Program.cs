﻿namespace Topic_6_Assignment___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            Console.WriteLine("Welcome to my loop program demo.");

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Please select one of the demos:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - PercentPassing");
                Console.WriteLine("3 - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose the Prompter demo");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose the PercentPassing demo");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PercentPassing();
                }
                
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to try again.");
                    Console.ReadLine();
                }
            }
        }

        public static void Prompter()
        {
            int max, min, number;
            Console.WriteLine("Welcome to the Prompter demo!");
            Console.WriteLine("Please input a minimum numeric integer value");

            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("That is not a valid input, please try again:");
            }

            Console.WriteLine("Now give me a maximum integer value");

            while (!Int32.TryParse(Console.ReadLine(), out max) || max <= min)
            {
                Console.WriteLine("That is not a valid input, please try again:");
            }

            Console.WriteLine($"Now, input a number between those two values {min} and {max}");

            while (!Int32.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Console.WriteLine("That is not a valid input. Make sure you input a whole number between the maximum and the minimum values");
            }

            Console.WriteLine($"The number you chose between {min} and {max} was {number}. Thank you for trying this demo.");
            Console.WriteLine("Press ENTER to close this demo");
            Console.ReadLine();
        }

        public static void PercentPassing()
        {
            int grade, below70, above70, gradeNum;
            bool done = false;
            Console.WriteLine("Welcome to the PercentPassing demo!");
            Console.WriteLine("Give me some percentile grades, and I'll tell you what percent of them are equal to or above 70");

            while (!done)
            {
                Console.WriteLine("Give me a percentile grade between 0 and 100. (Don't include the %)");

                while(!Int32.TryParse(Console.ReadLine(), out grade) || grade > 100 || grade < 0)
                {

                }

            }
        }


    }
}