class ListingActivity : Activity
{
    
    
    // 
        Random randoms = new Random();

        List<string> Listings = new List<string>

       {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
       };

       public ListingActivity()
    {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public override void activity()
    {
        Console.ReadLine();
        
    }

    public void DisplayListPrompt()
    {   Console.WriteLine("List as many responses you can to the following propmt:");
        int listIndex = randoms.Next(Listings.Count);
        string list = Listings[listIndex];
        Console.WriteLine($"--- {list} ---");
        
     }
    public void ShowListCountdown(string message)
    {
        int countdown = 10;
        Console.Write(message);
        while (countdown > 0)
        {

            Console.Write(countdown);
            // Thread.Sleep(500);

            Console.Write("\b \b");
            countdown--;
        }

        Console.WriteLine();
    }

}

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
// After the starting message, select a random prompt to show the user such as:

// Who are people that you appreciate?
// What are personal strengths of yours?
// Who are people that you have helped this week?
// When have you felt the Holy Ghost this month?
// Who are some of your personal heroes?
// After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
// The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
// The activity them displays back the number of items that were entered.
// The activity should conclude with the standard finishing message for all activities.