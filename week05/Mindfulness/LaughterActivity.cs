using System;
using System.Collections.Generic;

// A specific mindfulness activity that encourages laughter
public class LaughterActivity : Activity
{
    // List of funny/laughter messages and emojis
    private List<string> _laughs = new List<string>
    {
        "😂 Haha!",
        "🤣 Hehe!",
        "😆 Hoho!",
        "😹 Hahaha!",
        "😄 Ha!",
        "😁 😁 😁",
        "😜 Teehee!",
        "🙃 Giggle!",
        "😝 Snort!",
        "😛 Bwahaha!"
    };

    // Overrides the abstract method to perform the laughter activity
    protected override void PerformActivity()
    {
        Random rand = new Random(); // Create a random number generator
        int duration = GetDuration(); // Get the user-specified duration

        Console.WriteLine("\nLet’s laugh together");
        DateTime endTime = DateTime.Now.AddSeconds(duration); // Calculate when to stop

        // Loop until the activity duration is over
        while (DateTime.Now < endTime)
        {
            // Select a random laugh message
            string laugh = _laughs[rand.Next(_laughs.Count)];

            // Display the selected laugh
            Console.WriteLine(laugh);

            // Wait for 2 seconds using a spinner animation
            ShowSpinner(2);
        }

        // End message after the activity finishes
        Console.WriteLine("\nHope that brought a smile to your face");
    }
}