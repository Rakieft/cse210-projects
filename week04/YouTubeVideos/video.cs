using System;
using System.Collections.Generic;

// Class to represent a YouTube video
public class Video
{
    private string title; // Title of the video
    private string author; // Author of the video
    private int length; // Duration of the video in seconds
    private List<Comment> comments; // List of comments on the video

    // Constructor to initialize a video
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>(); // Initialize an empty list of comments
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the total number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to display video details
    public void DisplayVideoInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Duration: " + length + " seconds");
        Console.WriteLine("Number of comments: " + GetCommentCount());
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine("- " + comment.GetCommentInfo());
        }
        Console.WriteLine();
    }
}