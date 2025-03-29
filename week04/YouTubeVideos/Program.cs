using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // List to store multiple videos
        List<Video> videos = new List<Video>();

        // Creating the first video
        Video video1 = new Video("C# Tutorial for Beginners", "Jean Jr Dorestant", 600);
        video1.AddComment(new Comment("Clervil", "Great tutorial"));
        video1.AddComment(new Comment("Quelitho", "Very helpful, thanks"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        // Creating the second video
        Video video2 = new Video("How to Cook Pasta", "Chef Marie Vierge", 450);
        video2.AddComment(new Comment("David", "This recipe is amazing"));
        video2.AddComment(new Comment("Moise", "Simple and delicious."));
        video2.AddComment(new Comment("Dorestant", "Can you share more recipes?"));
        videos.Add(video2);

        // Creating the third video
        Video video3 = new Video("Top 10 Travel Destinations", "T-machan", 720);
        video3.AddComment(new Comment("George", "Adding these to my bucket list"));
        video3.AddComment(new Comment("Hanna", "Love the visuals"));
        video3.AddComment(new Comment("Isaac", "Amazing places"));
        videos.Add(video3);

        

        // Displaying the details of each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
