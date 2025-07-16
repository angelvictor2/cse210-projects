
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What did You learn Today?",
        "How do you feel today?",
        "What are you grateful for?",
        "Who did you know today?",
        "What would you change today?",
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}