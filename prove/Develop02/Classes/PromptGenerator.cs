using System;
using System.Collections.Generic;
public class PromptGenerator
{
    // Attributes:
    // List of Prompts
    public List<string> _promptList = new List<string>() { "Who was the most interesting person you talked to today?", "What was the weather like today?", "Write one word to describe your day." };

    public string GetRandomPrompt()
    {
        Random Random = new Random();
        int index = Random.Next(_promptList.Count);
        return _promptList[index];
    }

    public void AddPrompt(string newPrompt)
    {
        _promptList.Add(newPrompt);
    }
}