using System;
abstract class Exercise
{
    protected string _exerciseName;
    protected string _description;
    protected int _duration;

    protected int _progress = 1;

    public Exercise()
    {
        _exerciseName = "";
        _description = "";
        _duration = 0;

    }

    public void ShowOpeningMessage()

    {

        Console.WriteLine($"Welcome to the {_exerciseName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        _PromptDuration();
        Console.WriteLine();
        Console.WriteLine("Instructions:");
        ShowInstructions();
    }

    public void ShowConclusionMessage()
    {
        Console.Write($"You have completed another {_duration} seconds of the {_exerciseName}.");
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


    public void ProgressAnimation()
    {
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(_progress);
        Thread.Sleep(500);
        Console.Write("\b \b");
        if (_progress >= 10) Console.Write("\b \b");
        if (_progress > 100) Console.Write("\b \b");
        _progress++;
    }
    

    public abstract void ShowInstructions();
    public abstract void MainExercise();

    public void RunExercise()
    {
        Console.WriteLine();
        ShowSpinner("Starting exercise...", true);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();
        Console.Write("START");
        while (currentTime < futureTime)
        {
            MainExercise();
            currentTime = DateTime.Now;
        }
        Console.Write("END");
        Console.WriteLine();

        ShowSpinner("Exercise completed!");
    }

}



