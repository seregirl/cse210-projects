using System;

class Program
{
  static void Main(string[] args)
  {
    List<string> Actions = new List<string>()
                    {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "RecordEvents", "Quit"};

    EternalQuest eternalQuest = new EternalQuest();
    Console.WriteLine("Hello Develop05 World!");
    Console.WriteLine("Welcome to the Eternal Quest program!");

    bool quit = false;

    while (quit == false)
    {
      Console.WriteLine();
      Console.WriteLine($"You have {eternalQuest.getTotalPoints()} points.");
      Console.WriteLine();
      Console.WriteLine("Menu Options: ");

      int index = 1;
      foreach (string act in Actions)
      {
        Console.WriteLine($"{index}. {act}");
        index++;
      }

      Console.Write("Select a choice from the menu: ");
      switch (Console.ReadLine())
      {
        case "1":
          eternalQuest.CreateGoal();
          break;
        case "2":
          eternalQuest.ListGoals();
          break;
        case "3":
          eternalQuest.SaveGoals();
          break;
        case "4":
          eternalQuest.LoadGoals();
          break;
        case "5":
          eternalQuest.RecordEvents();
          break;
        case "6":
          quit = true;
          Console.WriteLine("You have quit the exercise program");
          break;
        default:
            Console.WriteLine("You have selected an invalid option. Please choose from 1 to 6.");
            break;
      }
      Console.WriteLine();
    }
  }
}