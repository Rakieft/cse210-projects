using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, string> scriptures = new Dictionary<string, string>
    {
        { "Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding." },
        { "John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
        { "Philippians 4:13", "I can do all things through Christ who strengthens me." },
        { "Matthew 5:9", "Blessed are the peacemakers, for they will be called children of God." },
        { "Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose." },
        { "Psalm 23:1", "The Lord is my shepherd, I lack nothing." }
    };

    static void Main()
    {
        Console.WriteLine("Enter a scripture reference (e.g., Proverbs 3:5-6), type 'random' for a random verse, or 'lookup' to search for a verse:");
        string inputRef = Console.ReadLine()?.Trim().ToLower();

        string selectedRef = null;
        string scriptureText = null;

        if (inputRef == "random")
        {
            selectedRef = scriptures.Keys.ElementAt(new Random().Next(scriptures.Count));
            scriptureText = scriptures[selectedRef];
        }
        else if (inputRef == "lookup")
        {
            Console.Write("Enter book name: ");
            string book = Console.ReadLine()?.Trim();
            Console.Write("Enter chapter: ");
            int chapter = int.Parse(Console.ReadLine()?.Trim() ?? "0");
            Console.Write("Enter verse (or range, e.g., 5-6): ");
            string verseInput = Console.ReadLine()?.Trim();

            selectedRef = $"{book} {chapter}:{verseInput}";
            scriptureText = LookupScripture(selectedRef);

            if (string.IsNullOrEmpty(scriptureText))
            {
                Console.WriteLine("Scripture not found. Exiting...");
                return;
            }
        }
        else
        {
            selectedRef = inputRef;
            if (!scriptures.ContainsKey(selectedRef))
            {
                Console.WriteLine("Scripture not found. Exiting...");
                return;
            }
            scriptureText = scriptures[selectedRef];
        }

        // Parse reference
        string[] parts = selectedRef.Split(' ');
        string bookName = parts[0];
        string[] chapterAndVerses = parts[1].Split(':');
        int chapterNumber = int.Parse(chapterAndVerses[0]);

        string[] verses = chapterAndVerses[1].Split('-');
        int startVerseNumber = int.Parse(verses[0]);
        int? endVerseNumber = (verses.Length > 1) ? int.Parse(verses[1]) : (int?)null;

        var scripture = new Scripture(new Reference(bookName, chapterNumber, startVerseNumber, endVerseNumber), scriptureText);

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords(2);
        }

        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ends.");
    }

    static string LookupScripture(string reference)
    {
        return scriptures.ContainsKey(reference) ? scriptures[reference] : null;
    }
}