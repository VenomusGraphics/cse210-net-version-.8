// Scripture.cs
public class Scripture
{
    private string reference;
    private string text;

    
    public Scripture()
    {
    }

    // Property for Reference
    public string Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    // Property for Text
    public string Text
    {
        get { return text; }
        set { text = value; }
    }
}


