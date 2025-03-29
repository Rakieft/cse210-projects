using System;

// Class to represent a comment
public class Comment
{
    private string commenterName; // Name of the person who made the comment
    private string text; // Text of the comment

    // Constructor to initialize a comment
    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    // Method to return the formatted comment string
    public string GetCommentInfo()
    {
        return commenterName + ": " + text;
    }
}