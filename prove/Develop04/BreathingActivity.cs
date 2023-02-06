
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public override void activity()
    {
        ShowBreathing("Breath in...");
        ShowBreathing("Now breath out...");
        Console.WriteLine();
    }

    public void ShowBreathing(string message)
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