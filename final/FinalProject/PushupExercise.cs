
class PushupExercise : Exercise
{
  List<string> instructions = new List<string>()
                    {
                        "Contract your abs and tighten your core by pulling your belly button toward your spine.",
                        "Inhale as you slowly bend your elbows and lower yourself to the floor, until your elbows are at a 90-degree angle.",
                        "Exhale while contracting your chest muscles and pushing back up through your hands, returning to the start position." 
                    };
  
    public PushupExercise()
    {
        _exerciseName = "Pushup Exercise";
        _description = "The push-up (sometimes called a press-up) is a common calisthenics exercise beginning from the prone position.";
    }

    public override void MainExercise()
    {
        ProgressAnimation();
    }

    public override void ShowInstructions() {
            foreach (string instruction in instructions)
            {
              ShowSpinner($" > {instruction}", true);
            }
    }

}