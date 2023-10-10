namespace Topic_6_Assignment___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            Console.WriteLine("Welcome to my loop program demo.");

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Please select one of the demos:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - PercentPassing");
                Console.WriteLine("3 - OddSum");
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
                else if (choice == "3")
                {
                    Console.WriteLine("You chose the OddSum demo");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    OddSum();
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Okay, I'll see you later!");
                    Environment.Exit(0);
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
            double grade, below70, above70, gradeNum;
            bool done = false;
            string answer;
            below70 = 0;
            above70 = 0;
            gradeNum = 0;
            Console.WriteLine("Welcome to the PercentPassing demo!");
            Console.WriteLine("Give me some percentile grades, and I'll tell you what percent of them are equal to or above 70");

            while (!done)
            {
                Console.WriteLine("Give me a percentile grade between 0 and 100. (Don't include the %)");

                while(!Double.TryParse(Console.ReadLine(), out grade) || grade > 100 || grade < 0)
                {
                    Console.WriteLine("I'm sorry, that's not a valid input. Please ensure your inputted grade is between 0 and 100");
                }

                gradeNum++;
                Math.Round(grade, 2);
                Console.WriteLine($"Your inputted grade is {grade}%");

                if (grade >= 70)
                {
                    above70++;
                }
                else
                {
                    below70++;
                }

                Console.WriteLine("Would you like to input another grade? (Yes/No)");
                
                answer = Console.ReadLine().ToUpper().Trim();

                while (answer != "YES" && answer != "NO")
                {
                    Console.WriteLine("That is not a valid response, please try again.");
                    answer = Console.ReadLine().ToUpper().Trim();
                }

                if (answer == "YES")
                {
                    Console.WriteLine("Okay.");
                }
                else if (answer == "NO")
                {
                    Console.WriteLine("Okay");
                    Thread.Sleep(1250);
                    done = true;
                }
                else
                {
                    Console.WriteLine("How did this happen?");
                    Environment.Exit(0);
                }
            }
            
            Console.WriteLine($"Out of {gradeNum} grades, {above70} were above or equal to 70%, and {below70} were below 70%.");
            Console.WriteLine($"That means {Math.Round(above70/gradeNum*100), 2}% of them were above 70%");
            Console.WriteLine("Press ENTER to exit this demo");
            Console.ReadLine();

        }

        public static void OddSum()
        {

        }
    }
}