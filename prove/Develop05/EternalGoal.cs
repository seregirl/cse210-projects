class EternalGoal : Goal {

  public EternalGoal(string name, string description, int points):base(name, description, points){
    _type = "EternalGoal";
  }
 public override void RecordEvent()
  {
    _accomplishedPoints += _pointsPerGoal;
  }
  public override bool IsComplete()
  {
    return _isComplete;
  }
}