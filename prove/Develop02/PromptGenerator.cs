using System;

public class PromptGenerator
{
     public string[] _prompts = new string[]
     {
          "What was the most interesting part of your day? ",
          "What was craziest thought I had about yourself? ",
          "How has the spirit guided you today? ",
          "What would you do different tomorrow? ",
          "Who do you want to reach out to next time? ",
     };

     public string GetRandomPrompt()
     {
          Random randomGenerator = new Random();
          int randomIndex = randomGenerator.Next(0, _prompts.Length);
          string randomPrompt = _prompts[randomIndex];
          return randomPrompt;
     }

   

    
}
