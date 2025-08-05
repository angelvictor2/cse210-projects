using System;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

    
        Video video1 = new Video("Soccer Game Highlights", "Chef Mario", 300);
        video1.AddComment(new Comment("Alice", "Great game!"));
        video1.AddComment(new Comment("Bob", "I loved the final goal."));
        video1.AddComment(new Comment("Charlie", "Post more matches, please!"));
        videos.Add(video1);

        Video video2 = new Video("How to Work in a Call Center", "CodeMaster", 600);
        video2.AddComment(new Comment("Daisy", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Ethan", "Can you explain the hiring process?"));
        video2.AddComment(new Comment("Fiona", "Subscribed!"));
        videos.Add(video2);


        Video video3 = new Video("What It's Like to Be a Software Engineer", "PetLovers", 180);
        video3.AddComment(new Comment("George", "This is exactly what I needed."));
        video3.AddComment(new Comment("Hannah", "Very inspiring, thanks!"));
        video3.AddComment(new Comment("Ivan", "Make one about internships too!"));
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.Write(video.GetComments());

            Console.WriteLine(); // Blank line between videos
        }
    }
}