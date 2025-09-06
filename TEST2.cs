using System;

class ChatBot
{
    public void Start() // <-- Fixed typo here
    {
        Console.WriteLine("Hello! I am your time-telling chatbot.");
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine()?.ToLower();

            if (input == null || input.Contains("exit") || input.Contains("quit"))
            {
                Console.WriteLine("ChatBot: Goodbye!");
                break;
            }
            else if (input.Contains("time"))
            {
                Console.WriteLine($"ChatBot: The current time is {DateTime.Now:hh:mm tt}");
            }
            else
            {
                Console.WriteLine("ChatBot: Ask me for the time or type 'exit' to quit.");
            }
        }
    }

    static void Main()
    {
        new ChatBot().Start(); // <-- This now matches the method name
    }
}