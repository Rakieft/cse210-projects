using System;
using System.Data.Common;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";
        
        
        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        // for the sign
        if (letter != "A" && letter != "F")
        {
            int lastDigit = percent % 10;

            if (lastDigit >= 7)  // <-- Fixed the misplaced "else if"
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

        }
        Console.WriteLine($"Your percent is {letter} {sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Passed!");
        }

        else if (percent < 70)
        {
            Console.WriteLine("Yiy will have better luck next time");
        }


    }
}