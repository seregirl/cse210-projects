using System;
class ScriptureMemorizer{
    //  Keeps track of a single word and whether it is shown or hidden.
    private Scripture scripture;
    private List<string> scriptureTextList;
    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }
   private void convertTextToList()
   {
        scriptureTextList = scripture.ToString().Split("").ToList();
   }
   public void removeWordsFromText()
   {
    int numWordToRemove = new Random().Next(2, 4);
    int wordRemoved = 0;
    
    do {
        int rndindex = new Random().Next(0, scriptureTextList.Count());
        scriptureTextList[rndindex] = new string('_', scriptureTextList[rndindex].Length);
        wordRemoved ++;
    }while (wordRemoved != numWordToRemove);

   }
    public  string toString()
    {
        return string.Join(' ', scriptureTextList);
    }
    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
            {
                if (word.Contains('_') == false)
                retvalue = true;
                break;
            }
        return retvalue;

    }
}









// GetVerseText() : string
// SetVerseText() : void

// 	UnderscoreWord() : string
