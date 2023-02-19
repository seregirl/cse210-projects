class ChecklistGoal : Goal {
  private int _bonusTimes;
  private int _bonusAmount;
  private int _completedBonus = 0;

  public ChecklistGoal(string name, string description, int points, int bonusTimes, int bonusAmount):base(name, description, points){
    _bonusTimes = bonusTimes;
    _bonusAmount = bonusAmount;
    _type = "ChecklistGoal";
  }

  public void SetCompletedBonus(int completedBonus) {
    _completedBonus = completedBonus;
  }

  public override string GetOutput(){
    string asterik = " ";
    if (IsComplete()) asterik = "x";
    return $"[{asterik}] {_name} ({_description}) -- Currently completed: {_completedBonus}/{_bonusTimes}";
  }

  public override string GetFileOutput(){
    return $"{base.GetFileOutput()}::{_bonusTimes}::{_bonusAmount}::{_completedBonus}";
  }

  public override void RecordEvent()
  {
    _completedBonus++;
    _accomplishedPoints += _pointsPerGoal;
    if (_completedBonus == _bonusTimes) {
      _accomplishedPoints += _bonusAmount;
      _completedBonus = 0;
      _isComplete = true;
    }
  }
  public override bool IsComplete()
  {
    return _isComplete;
  }
}