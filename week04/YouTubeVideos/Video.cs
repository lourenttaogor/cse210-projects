using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public List<Comment> _comment;
    
    public int Count => _comment.Count;
    
    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    
        Console.WriteLine($"{_title}, {_author}, {_length}s");
    }

    public void AddComment(Comment comment)
    { 

        _comment.Add(comment);
    }

    public void GetNumberOfComment()
    {
        Console.WriteLine($"Number of Comment(s): {Count}");
    }
}