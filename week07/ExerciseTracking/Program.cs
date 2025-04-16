using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list of activities with examples of each type
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 5.0), // Running activity for 30 minutes with a distance of 5 km
            new Cycling(new DateTime(2022, 11, 3), 30, 20.0), // Cycling activity for 30 minutes with a speed of 20 km/h
            new Swimming(new DateTime(2022, 11, 3), 30, 40)   // Swimming activity for 30 minutes with 40 laps
        };

        // Create an ActivityTracker instance to manage statistics and personal records
        ActivityTracker tracker = new ActivityTracker();

        // Add each activity to the tracker
        foreach (var activity in activities)
        {
            tracker.AddActivity(activity);
        }

        // Display statistics for all activities (total distance, average speed, and average pace)
        tracker.DisplayStatistics();

        // Display the user's personal best records (best distance and best time)
        tracker.DisplayBestRecords();

        // Display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}