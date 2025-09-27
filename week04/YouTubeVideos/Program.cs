using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        List<YouTubeVideo> youTubeVideos = new List<YouTubeVideo>();

        YouTubeVideo youTubeVideo1 = new YouTubeVideo("Programming with Python", "Microsoft Developers", 100);
        youTubeVideo1.AddComment(new Comment("James", "Great step by microsoft"));
        youTubeVideo1.AddComment(new Comment("Irene", "What an energetic and confident style of speaking"));
        youTubeVideo1.AddComment(new Comment("Paul", "Python  is amazing !!"));
        youTubeVideos.Add(youTubeVideo1); // Adding all video to the list


        YouTubeVideo youTubeVideo2 = new YouTubeVideo("MySql1 Workbench Tutorials", "BYU IDAHO", 450);
        youTubeVideo2.AddComment(new Comment("Beatrice", "The video is fantastic"));
        youTubeVideo2.AddComment(new Comment("Erica", "Watching this video saved me much time"));
        youTubeVideo2.AddComment(new Comment("Jen", "The most informative tutorial on MySQL"));
        youTubeVideos.Add(youTubeVideo2);


        YouTubeVideo youTubeVideo3 = new YouTubeVideo("Math for Real World", "BYU IDAHO", 300);
        youTubeVideo3.AddComment(new Comment("Joan", "Clear and Concise"));
        youTubeVideo3.AddComment(new Comment("Derek", "I really enjoyed this video"));
        youTubeVideo3.AddComment(new Comment("Prince", "Thank You Sir"));
        youTubeVideo3.AddComment(new Comment("Philip", "I love maths"));
        youTubeVideos.Add(youTubeVideo3);

        foreach (YouTubeVideo yt in youTubeVideos)
        {
            Console.WriteLine("------------------------------------------");
            yt.DisplayVideoInfo();
            yt.DisplayAllComments();
            Console.WriteLine("------------------------------------------");
        }











    }
}