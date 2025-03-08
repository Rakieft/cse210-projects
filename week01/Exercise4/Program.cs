using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int magicNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        // Collect numbers from the user
        do
        {
            Console.Write("Please enter your number: ");
            magicNumber = int.Parse(Console.ReadLine());
            if (magicNumber != 0)
            {
                numbers.Add(magicNumber);
            }

        } while (magicNumber != 0);  

        // Compute the sum
        int sum = numbers.Sum();

        // Compute the average
        float average = (float)sum / numbers.Count;

        // Find the largest number
        int largest = numbers.Max();

        // Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch Challenge: Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}