using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var availableWords = Words.Where(w => !w.IsHidden).ToList();
        if (availableWords.Count == 0) return;

        int wordsToHide = Math.Min(count, availableWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public void Display()
    {
        if (!Console.IsOutputRedirected) // Prevent Console.Clear() errors
        {
            Console.Clear();
        }

        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }
}