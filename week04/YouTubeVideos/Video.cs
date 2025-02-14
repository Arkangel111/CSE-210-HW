using System;
public class Video

{
    private int _length;
    private string _author;
    private string _title;
    private List<Comment> _comments;

    public Video(int length, string author, string title)
    {
        _length = length;
        _author = author;
        _title = title;
        _comments = new List<Comment>();
    }


    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comment count: {CommentCount()}");
        Console.WriteLine("\nUser comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  {comment.GetUserName()} - {comment.GetComment()}");
        }
        Console.WriteLine("======================");
    }

}
