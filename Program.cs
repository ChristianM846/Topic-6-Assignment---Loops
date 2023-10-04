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
                    Console.WriteLine("You the Prompter demo");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }

        static void Prompter()
        {

        }

    }
}