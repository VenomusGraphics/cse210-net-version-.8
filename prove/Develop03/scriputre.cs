class Scripture
{
    private string reference;
    private string text;

    public string Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public string HideRandomWords()
    {
        string[] words = text.Split(' ');
        Random random = new Random();
        int numberOfWordsToHide = random.Next(1, words.Length / 2);

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int indexToHide = random.Next(0, words.Length);
            words[indexToHide] = "_____"; // Replace with asterisks to hide the word
        }

        return string.Join(" ", words);
    }
}