using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord With all thine heart and lean not unto thine understanding; in all things aknowledge Him and He will direct thy path.");
        ScriptureMemorizer scripturememorizer = new ScriptureMemorizer(scripture);
    
        string userInput = "";
        
        while(userInput != "quit" && scripturememorizer.hasWordsLeft() == true)
        
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scripturememorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scripturememorizer.removeWordsFromText();
        }
        
        
        
        
    }
}

