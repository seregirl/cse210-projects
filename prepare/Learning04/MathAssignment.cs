class MathAssignment : Assignment
{
   private string _textbookSection;
    private string _problems;
    
    public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic)
    { 
        _textbookSection =textbookSection;
        _problems = problems;
    }
     public string GetHomeworkList()
    {
        
        return string.Format("{0} {1}", _textbookSection, _problems);
}
}
   
            