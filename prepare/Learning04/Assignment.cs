using System;

class Assignment
{
   protected string _studentName;
    protected string _topic;
    
    public Assignment(string studentName, string topic)
    { 
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        // return _studentName;
        return string.Format("{0} - {1}", _studentName, _topic);
    }
}