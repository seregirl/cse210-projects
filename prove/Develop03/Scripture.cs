using System;
// Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
class Scripture{
    private string scripturetext;
    private Reference scriptureReference;
    public Scripture (Reference _scriptureReference, string _scripturetext)
    {
        scriptureReference =_scriptureReference;
        scripturetext = _scripturetext;
    }
        public string toString()
        {
            return string.Format("{0}", scripturetext);
        }
    }
    
    
// GetVerseText() : string
// SetVerseText() : void
// GetScripture() : string

// sbyte = new Scripture('Proverb 3:5-6')