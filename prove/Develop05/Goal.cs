abstract class Goal {
  protected string _name;
  protected string _description;

  protected string _type;
  protected int _pointsPerGoal;

  protected int _accomplishedPoints = 0;

  protected bool _isComplete = false;

  public Goal(string name, string description, int points) {
    _name = name;
    _description = description;
    _pointsPerGoal = points;
  }

  public string GetName() {
    return _name;
  }

  public int GetPointsPerGoal() {
    return _pointsPerGoal;
  }

  public void SetAccomplishedPoints(int points) {
    _accomplishedPoints = points;
  }
  public void SetCompleteStatus(bool isComplete) {
    _isComplete = isComplete;
  }
  public int GetAccomplishedPoints() {
    return _accomplishedPoints;
  }

  public virtual string GetOutput(){
    string asterik = " ";
    if (IsComplete()) asterik = "x";
    return $"[{asterik}] {_name} ({_description})";
  }

  public virtual string GetFileOutput(){
    return $"{_type}::{_name}::{_description}::{_pointsPerGoal}::{_accomplishedPoints}";
  }


  public abstract void RecordEvent();
  public abstract bool IsComplete();

}