using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

          List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Things to know about BYU pathway", "Mitchelle", 420);
        video1.AddComment(new Comment("Alice", "This review was super helpful!"));
        video1.AddComment(new Comment("Bob", "I love the Tuition discount."));
        video1.AddComment(new Comment("Charlie", "Very detailed and honest."));
        videos.Add(video1);

        // Video 2
        Video video2 = new ("Unveiling the new me GUI", "TechGeek", 315);
        video2.AddComment(new Comment("Mirabel", "Can’t wait to try it myself!"));
        video2.AddComment(new Comment("Joseph", "Awesome Unveiling!"));
        video2.AddComment(new Comment("Fiona", "Good visuals and sound quality."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("5 Tips for Using the New Device", "HelpfulHacks", 600);
        video3.AddComment(new Comment("Fred", "Tip #3 saved me so much time."));
        video3.AddComment(new Comment("Benita", "This was gold. Subscribed!"));
        video3.AddComment(new Comment("spencer", "Simple and easy to follow."));
        videos.Add(video3);

        // Display all video details
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}