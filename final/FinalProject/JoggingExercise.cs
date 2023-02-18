
class JoggingExercise : Exercise
{
  List<string> instructions = new List<string>()
                    {
                        "While jogging, maintain good posture, engage your core, and gaze forward.",
                        "Avoid tilting your head down and slumping your shoulders.",
                        "Broaden your chest, and keep it lifted as you draw your shoulders down and back.",
                        "Keep your hands loose, and use a relaxed arm swing."
                    };
  
    public JoggingExercise()
    {
        _exerciseName = "Jogging Exercise";
        _description = "Jogging is a form of trotting or running at a slow or leisurely pace. The main intention is to increase physical fitness with less stress on the body than from faster running but more than walking, or to maintain a steady speed for longer periods of time.";
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