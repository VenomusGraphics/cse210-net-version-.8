public class Comment
{
    public string UserName { get; set; }
    public string Oppinon { get; set; }

    public Comment(string name, string oppinon )
    {
        UserName = name;
        Oppinon  = oppinon ;
    }

    public string GetCommentDetails()
    {
        return $"{UserName}: {Oppinon}";
    }
}
