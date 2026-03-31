using System.Reflection;

public class Video
{
   private string _title;
   private string _author;
   private int _length;
   private List<Comment> _comments = new List<Comment>();

    public Video(string title,string author,int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {   
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string DisplayVideoInformation()
    {
        return $"Title: {_title}, Author: {_author}, Length in seconds: {_length}, number of comments: {this.GetNumberOfComments()}";
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

}