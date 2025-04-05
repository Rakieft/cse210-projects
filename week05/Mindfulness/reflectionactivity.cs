using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override void PerformActivity()
    {
        Random rand = new Random();
        int duration = GetDuration();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("Think about it...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
}