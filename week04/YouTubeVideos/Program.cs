using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create 3-4 video objects
        Video video1 = new Video("Introduction to C#", "CodeMaster", 1200); // 20 minutes
        Video video2 = new Video("Understanding Abstraction", "TechGuru", 900); // 15 minutes
        Video video3 = new Video("Building Your First App", "DevJourney", 1800); // 30 minutes
        Video video4 = new Video("Debugging Tips for Beginners", "BugBuster", 600); // 10 minutes

        // Add 3-4 comments to each video
        video1.AddComment("Alice", "Great intro! Very clear explanations.");
        video1.AddComment("Bob", "Helped me understand the basics quickly.");
        video1.AddComment("Charlie", "Could you do a video on advanced topics next?");
        video1.AddComment("Diana", "Perfect for beginners, thanks!");

        video2.AddComment("Eve", "This really clarified abstraction for me.");
        video2.AddComment("Frank", "Excellent examples, very helpful.");
        video2.AddComment("Grace", "Mind blown! So much simpler now.");

        video3.AddComment("Heidi", "Followed along and built my first app!");
        video3.AddComment("Ivan", "Your teaching style is amazing.");
        video3.AddComment("Judy", "What framework did you use for this?");

        video4.AddComment("Kyle", "These tips saved me hours!");
        video4.AddComment("Liam", "Wish I knew this earlier.");
        video4.AddComment("Mia", "Short and to the point, love it!");
        video4.AddComment("Noah", "Any tips for debugging async code?");


        // Put all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Iterate through the list of videos and display their information
        Console.WriteLine("--- YouTube Video Program ---");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails(); // Displays title, author, length, and comment count
            video.DisplayComments();    // Displays all individual comments
        }
        Console.WriteLine("\n--- End of Program ---");
    }
}
