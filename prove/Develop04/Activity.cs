// _StartingMessage: string
// _Description: string
// _Duration: int
// _EndingMessage: string
// GetStartingMessage(): string
// GetEndingMessage(): string
using System;
class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _activityName = "";
        _description = "";
        _duration = 0;

    }

    public void DisplayStartingMessage()

    {

        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        _PromptDuration();
        Console.WriteLine();
        ShowSpinner("Getting ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.Write($"You have completed another {_duration} seconds of the {_activityName}.");
        ShowSpinner("");
    }

    private void _PromptDuration()
    {

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void ShowSpinner(string message, bool inline=false)
    {
        int repeat = 6;
        if (inline) {
        Console.Write($"{message} ");
        } else {
        Console.WriteLine(message);
        }
        while (repeat > 0)
        {
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");


            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");

             Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");


            repeat--;
        }

        Console.WriteLine();

    }
    // public void ShowSpinner(string message)
    // {
    //     int repeat = 6;
    //     Console.WriteLine(message);
    //     while (repeat > 0)
    //     {
    //         Console.Write("/");
    //         Thread.Sleep(500);

    //         Console.Write("\b \b");
    //         Console.Write("\\");
    //         Thread.Sleep(500);
    //         Console.Write("\b \b");
    //         repeat--;
    //     }

    //     Console.WriteLine("");

    // }


    public virtual void activity()
    {
        Console.WriteLine("Begin Activity");
        Thread.Sleep(500);
        Console.WriteLine("End Activity");
    }

    public void runActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            activity();
            currentTime = DateTime.Now;
        }
        Console.WriteLine();

        ShowSpinner("Well done!!");
    }

}



