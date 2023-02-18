class SimpleGoal : Goal {

  public SimpleGoal(string name, string description, int points):base(name, description, points){
    _type = "SimpleGoal";
  }
  public override void RecordEvent()
  {
    _accomplishedPoints += _pointsPerGoal;
    _isComplete = true;
  }
  public override bool IsComplete()
  {
    return _isComplete;
  }
}