using System;
using System.Collections.Generic;
using System.Linq;

public class ActivityTracker
{
    private List<Activity> activities = new List<Activity>();  
    private double bestDistance = 0;  
    private double bestTime = double.MaxValue;  

    // Method to add an activity to the tracker
    public void AddActivity(Activity activity)
    {
        activities.Add(activity);  // Add the activity to the list

        // Update the best distance and best time if applicable
        if (activity.GetDistance() > bestDistance)
            bestDistance = activity.GetDistance();
        if (activity.Minutes < bestTime)
            bestTime = activity.Minutes;
    }

    // Method to display statistics of all activities (total distance, average speed, average pace)
    public void DisplayStatistics()
    {
        double totalDistance = activities.Sum(a => a.GetDistance());  // Calculate total distance
        double totalSpeed = activities.Average(a => a.GetSpeed());  // Calculate average speed
        double totalPace = activities.Average(a => a.GetPace());  // Calculate average pace

        // Display the statistics
        Console.WriteLine($"Total Distance: {totalDistance:F2} km");
        Console.WriteLine($"Average Speed: {totalSpeed:F2} kph");
        Console.WriteLine($"Average Pace: {totalPace:F2} min per km");
    }


    public void DisplayBestRecords()
    {
        // Display the best records
        Console.WriteLine($"Best Distance: {bestDistance:F2} km");
        Console.WriteLine($"Best Time: {bestTime} minutes");
    }
}