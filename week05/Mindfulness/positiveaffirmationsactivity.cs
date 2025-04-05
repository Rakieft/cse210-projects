using System;
using System.Collections.Generic;

// A specific mindfulness activity that displays positive affirmations
public class PositiveAffirmationsActivity : Activity
{
    // List of positive affirmation strings
    private List<string> _affirmations = new List<string>
    {
        "You are capable of amazing things.",
        "You are strong, confident, and courageous.",
        "You can achieve anything you set your mind to.",
        "You are growing and improving every day.",
        "You are loved and appreciated.",
        "Your potential is limitless.",
        "You have the power to create change.",
        "You bring light to those around you.",
        "You deserve happiness and success.",
        "You are enough, just as you are."
    };

    // Overrides the abstract method to perform the affirmation activity
    protected override void PerformActivity()
    {
        Random rand = new Random(); // Create a random number generator
        int duration = GetDuration(); // Get the user-specified duration

        Console.WriteLine("\nLet the affirmations begin...");
        DateTime endTime = DateTime.Now.AddSeconds(duration); // Calculate end time

        // Loop until the activity duration is over
        while (DateTime.Now < endTime)
        {
            // Select a random affirmation from the list
            string affirmation = _affirmations[rand.Next(_affirmations.Count)];

            // Display the affirmation with a decorative bullet
            Console.WriteLine($"✦ {affirmation}");

            // Pause for a few seconds using the spinner animation
            ShowSpinner(3);
        }
    }
}