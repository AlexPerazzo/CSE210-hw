using System;
using System.Collections.Generic;
namespace Develop02.Classes
{
    public class PromptGenerator
    {
        // Attributes:
        // List of Prompts
        public List<string> _promptList = new List<string>() { "Who was the most interesting person you talked to today?", "What was the weather like today?", "Write one word to describe your day.", "What was the best part of your day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

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
}