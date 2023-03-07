using System;
using System.Collections.Generic;
 
public static class Extensions
{
    public static string Filter(this string wordToCount, List<char> charsToRemove)
    {
        
        return String.Concat(wordToCount.Split(charsToRemove.ToArray()));
    }
}