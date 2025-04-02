using System;
using System.Collections.Generic;

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
