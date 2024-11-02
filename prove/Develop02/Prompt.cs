public class Prompt
{
    private List<string> _prompts;

    public Prompt()
    {
        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "what was one good thing today?",
            "what do you need to work on after today?",
            "what do you love the most today?",
            "who is on your mind and why?",
            "how have you seen God's hand?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string writingPrompt = _prompts[index];

        return writingPrompt;
    }
}