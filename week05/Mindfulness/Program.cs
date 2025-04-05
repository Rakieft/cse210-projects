using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display the Wellness Program Menu
            Console.WriteLine("Wellness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Positive Affirmations");
            Console.WriteLine("5. Laughter Activity");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            // Declare a variable to hold the selected activity
            Activity activity = null;

            // Switch statement to handle the user's choice
            switch (choice)
            {
                case "1":
                    // Start the Breathing Activity
                    activity = new BreathingActivity();
                    activity.Start("Breathing", "This activity will help you relax by guiding you through slow breathing.");
                    break;
                case "2":
                    // Start the Reflection Activity
                    activity = new ReflectionActivity();
                    activity.Start("Reflection", "This activity will help you reflect on times you've shown strength.");
                    break;
                case "3":
                    // Start the Listing Activity
                    activity = new ListingActivity();
                    activity.Start("Listing", "This activity will help you reflect on the good things in your life.");
                    break;
                case "4":
                    // Start the Positive Affirmations Activity
                    activity = new PositiveAffirmationsActivity();
                    activity.Start("Positive Affirmations", "This activity will boost your confidence with affirmations.");
                    break;
                case "5":
                    // Start the Laughter Activity
                    activity = new LaughterActivity();
                    activity.Start("Laughter", "This activity will bring you joy through laughter.");
                    break;
                case "6":
                    // Exit the program if user chooses 6
                    return;
                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}