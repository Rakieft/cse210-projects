using System;
using System.Threading;

// Abstract base class for different types of mindfulness activities
public abstract class Activity
{
    // Private variable to store the duration of the activity
    private int _duration;

    // Starts the activity with a given name and description
    public void Start(string name, string description)
    {
        // Display the activity name and description
        Console.WriteLine($"Starting {name} Activity");
        Console.WriteLine(description);

        // Ask the user for the duration of the activity
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        // Display a short "Get ready" message with a spinner animation
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        // Call the method that performs the actual activity
        PerformActivity();

        // Display completion message and show spinner again
        Console.WriteLine("\nGreat job");
        Console.WriteLine($"You have completed the {name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    // Abstract method to be implemented by derived classes to define the activity behavior
    protected abstract void PerformActivity();

    // Getter method to access the duration from derived classes
    protected int GetDuration()
    {
        return _duration;
    }

    // Shows a simple spinner animation for a specified number of seconds
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        // Loop through the spinner frames until the time runs out
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]); // Display one frame
            Thread.Sleep(200); // Wait 200 milliseconds
            Console.Write("\b"); // Erase the last character to overwrite it
            i++;
        }
    }

    // Counts down from the given number of seconds to 1 with a 1-second pause between each
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Wait 1 second
        }
        Console.WriteLine(); // Move to the next line after countdown
    }
}