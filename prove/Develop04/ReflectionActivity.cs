
class ReflectionActivity : Activity
{
    Random random = new Random();
    Random random2 = new Random();
    
    List<string> promptLists = new List<string>
      {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                        };
    List<string> questions = new List<string>
    {
                            "Why was this experience meaningful to you?",
                            "Have you ever done anything like this before?",
                            "How did you get started?",
                            "How did you feel when it was complete?",
                            "What made this time different than other times when you were not as successful?",
                            "What is your favorite thing about this experience?",
                            "What could you learn from this experience that applies to other situations?",
                            "What did you learn about yourself through this experience?",
                            "How can you keep this experience in mind in the future?" };



    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }



    public override void activity()
    {
        ReflectionQuestions();
    }
    public void DisplayPrompt()
    {

        Console.WriteLine("Continue the following prompt");
        int randomIndex = random.Next(promptLists.Count);
        string prompt = promptLists[randomIndex];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine();
        ShowReflection("You may begin in ");
    }
    public void ReflectionQuestions()
    {
        int questionIndex = random2.Next(questions.Count);
        string question = questions[questionIndex];
        ShowSpinner($"> {question}", true);
        Thread.Sleep(1000);

       
    }
    public void ShowReflection(string message)
    {
        int countdown = 6;
        Console.Write(message);
        while (countdown > 0)
        {

            Console.Write(countdown);
            Thread.Sleep(500);

            Console.Write("\b \b");
            countdown--;
        }

        Console.WriteLine();
    }




}

