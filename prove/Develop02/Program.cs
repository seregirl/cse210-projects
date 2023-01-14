using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> Actions = new List<string>()
                    {"Write", "Display", "Load", "Save", "Quit"};
        List<string> Prompts = new List<string>()
                    {
                        "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"
                    };
        Journal journal = new Journal();            
        Random random = new Random();
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the journal program!");

        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine("Please select one of the following choices!");

            int index = 1;
            foreach (string act in Actions)
            {
                Console.WriteLine($"{index}. {act}");
                index ++;
            }

            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                int randomIndex = random.Next(Prompts.Count);
                string prompt = Prompts[randomIndex];
                Console.WriteLine(prompt);
                string userReply = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;

                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._response = userReply;
                entry._date = theCurrentTime.ToShortDateString();
                journal.AddEntry(entry);
            }
            else if (response == "2")
            {
                journal.DisplayEntries();
            }
            else if (response == "3")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadEntries(fileName);
            }
            else if (response == "4")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveEntries(fileName);
            }
            else if (response == "5")
            {
                quit = true;
                Console.WriteLine("Thanks for using our Journal. Please try another time. BYE!");
            }
            else
            {
                Console.WriteLine($"'{response}' is not a valid option. Please enter an option from 1 to 5");
            }

            Console.WriteLine();
        }
    }
}