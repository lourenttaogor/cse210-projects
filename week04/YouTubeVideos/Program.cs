using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        Video video1 = new Video("My Video Beauty", "Shana", 120);
        video1.AddComment(new Comment("Maya", "Very interesting movie"));
        video1.AddComment(new Comment("Mako", "Very boring movie"));
        video1.AddComment(new Comment("Dani", "I love the movie"));
        video1.GetNumberOfComment();
        _videoList.Add(video1);

        Video video2 = new Video("The Highland", "San Tiego", 150);
        video2.AddComment(new Comment("Maya", "Very interesting movie"));
        video2.AddComment(new Comment("Mako", "Very boring movie"));
        video2.AddComment(new Comment("Dani", "I love the movie"));
        video2.GetNumberOfComment();
        _videoList.Add(video2);

        Video video3 = new Video("London Bridge", "Mina Mana", 60);
        video3.AddComment(new Comment("Maya", "Very interesting movie"));
        video3.AddComment(new Comment("Mako", "Very boring movie"));
        video3.AddComment(new Comment("Dani", "I love the movie"));
        _videoList.Add(video3);
        video3.GetNumberOfComment();
        Console.WriteLine(_videoList);
    }
}