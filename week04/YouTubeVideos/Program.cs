using System;
using System.Collections.Generic;

// Comment Class
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Video Class
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Product Awareness Tips", "Sandra", 120);
        Video video2 = new Video("Marketing 101", "John Doe", 180);
        Video video3 = new Video("How to Spot Trends", "Jane Smith", 240);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great insights!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Looking forward to more content!"));

        // Add comments to video2
        video2.AddComment(new Comment("Diana", "This is gold!"));
        video2.AddComment(new Comment("Edward", "Amazing tips."));
        video2.AddComment(new Comment("Frank", "Well explained."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This was really interesting."));
        video3.AddComment(new Comment("Hank", "Thanks for sharing."));
        video3.AddComment(new Comment("Irene", "Clear and concise, love it!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}