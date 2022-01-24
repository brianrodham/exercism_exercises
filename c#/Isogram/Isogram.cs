using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var formattedWord = word.ToLower().Replace("-", string.Empty).Replace(" ", string.Empty);
        var characterSet = new HashSet<char>(formattedWord); 
        return characterSet.Count() == formattedWord.Length;
    }
}
