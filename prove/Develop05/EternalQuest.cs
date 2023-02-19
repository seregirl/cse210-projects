class EternalQuest {

  List<Goal> goals = new List<Goal>(){};
  private int _totalPoints = 0;
  public void CreateGoal() {
    Console.WriteLine("The types of Goals: ");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal ");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Which type of Goal would you like to create? ");
    string option = Console.ReadLine();
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());

    Goal goal;
    
    switch (option)
      {
        case "1":
          goal = new SimpleGoal(name, description, points);
          goals.Add(goal);
          break;
        case "2":
          goal = new EternalGoal(name, description, points);
          goals.Add(goal);
          break;
        case "3":
          Console.Write("How many times does this goal need to be accomplished for a bonus? ");
          int bonusTimes = int.Parse(Console.ReadLine());
          Console.Write("What is the bonus for accomplishing it that many times? ");
          int bonus = int.Parse(Console.ReadLine());
          goal = new ChecklistGoal(name, description, points, bonusTimes, bonus);
          goals.Add(goal);
          break;
      }

      
  }

  public void ListGoals() {
    Console.WriteLine("The goals are: ");
    int index = 1;
    foreach (Goal goal in goals)
      { 
        Console.WriteLine($"{index}. {goal.GetOutput()}");
        index++;
      }
  }

  public void SaveGoals() {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();
     using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetFileOutput());
            }
        }
  Console.Write($"Goals successfully saved to {filename}");
  }

  public void LoadGoals() {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("::");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int pointsPerGoal = int.Parse(parts[3]);
            int accomplishedPoints = int.Parse(parts[4]);
            
            if (type == "SimpleGoal") {
              bool isComplete = parts[5] == "True";
              SimpleGoal goal = new SimpleGoal(name, description, pointsPerGoal);
              goal.SetAccomplishedPoints(accomplishedPoints);
              goal.SetCompleteStatus(isComplete);
              goals.Add(goal);
            } else if (parts[0] == "EternalGoal") {
              EternalGoal goal = new EternalGoal(name, description, pointsPerGoal);
              goal.SetAccomplishedPoints(accomplishedPoints);
              goals.Add(goal);
            } else {
              int bonusTimes = int.Parse(parts[5]);
              int bonusAmount = int.Parse(parts[6]);
              int completedBonus = int.Parse(parts[7]);
              ChecklistGoal goal = new ChecklistGoal(name, description, pointsPerGoal, bonusTimes, bonusAmount);
              goal.SetAccomplishedPoints(accomplishedPoints);
              goal.SetCompletedBonus(completedBonus);
              goals.Add(goal);
            }
            
        }

  }

  public void RecordEvents() {
    Console.WriteLine("The goals are: ");
    int index = 1;
    foreach (Goal g in goals)
      { 
        Console.WriteLine($"{index}. {g.GetName()}");
        index++;
      }
      Console.WriteLine("Which goal did you accomplish? ");

      int goalNumber = int.Parse(Console.ReadLine());
      Goal goal = goals[goalNumber-1];
      goal.RecordEvent();
      Console.WriteLine($"Congratulations! You have earned {goal.GetPointsPerGoal()} points!");
      Console.WriteLine($"You now have {getTotalPoints()} points.");
  }

  public int getTotalPoints() {
    _totalPoints = 0;
     foreach (Goal goal in goals)
      { 
        _totalPoints += goal.GetAccomplishedPoints();
      }

      return _totalPoints;
  }
  
}