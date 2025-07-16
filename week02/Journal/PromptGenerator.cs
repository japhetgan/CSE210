public class PromptGenerator
{

    public List<string> _prompts = new List<string>
        {
            "What’s one thing I learned about myself today?",
            "How did I show kindness to someone today?",
            "What moment made me feel the most peace today?",
            "Was there a challenge I overcame today — big or small?",
            "Who or what inspired me today?",
            "When did I feel most connected to God or a higher purpose today?",
            "What conversation or moment made me feel truly heard or understood?",
            "Did I do something today that aligned with the kind of person I want to become?",
            "How did I take care of my physical or emotional health today?",
            "If today had a theme or title, what would it be — and why?"
        };

    public PromptGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}