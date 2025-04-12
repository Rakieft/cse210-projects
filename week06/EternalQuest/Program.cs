using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the GoalManager to handle all goal-related actions
        GoalManager goalManager = new GoalManager();

        string userChoice = ""; // Store the user's menu selection

        // Loop until the user chooses to quit (option 7)
        while (userChoice != "7")
        {
            // Display the main menu
            Console.WriteLine("=== Eternal Quest Menu ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score and Level");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");
            userChoice = Console.ReadLine(); // Get the user's choice

            // Take action based on user's choice
            switch (userChoice)
            {
                case "1":
                    // Create a new goal (Simple, Eternal, or Checklist)
                    goalManager.CreateGoal();
                    break;
                case "2":
                    // Display the list of all current goals
                    goalManager.ListGoals();
                    break;
                case "3":
                    // Prompt for a file name and save all goals to the file
                    Console.Write("Enter a filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveToFile(saveFile);
                    break;
                case "4":
                    // Prompt for a file name and load goals from the file
                    Console.Write("Enter a filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadFromFile(loadFile);
                    break;
                case "5":
                    // Record progress on a selected goal
                    goalManager.RecordEvent();
                    break;
                case "6":
                    // Display current score, level, and goal progress
                    goalManager.ListGoals();
                    break;
                case "7":
                    // Exit the program with a goodbye message
                    Console.WriteLine("Goodbye! Keep progressing on your Eternal Quest");
                    break;
                default:
                    // Handle any invalid menu input
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            // Add an empty line for spacing
            Console.WriteLine();
        }
    }
}