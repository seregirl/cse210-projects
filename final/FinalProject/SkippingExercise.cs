
class SkippingExercise : Exercise
{
  List<string> instructions = new List<string>()
                    {
                        "Hold the rope while keeping your hands at hip level.",
                        "Rotate your wrists to swing the rope and jump.",
                        "Jump with both feet at the same time, one foot at a time, alternating between feet, etc.",
                        "Repeat until the set is complete."
                    };
  
    public SkippingExercise()
    {
        _exerciseName = "Skipping Exercise";
        _description = "Skipping is great cardio, aerobic exercise. Skipping rope helps to tone your calves, tighten your core, build stamina and improve your lung capacity.";
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