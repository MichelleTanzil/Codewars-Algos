using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
// In this kata you are required to, given a string, replace every letter with its position in the alphabet.

// If anything in the text isn't a letter, ignore it and don't return it.

// "a" = 1, "b" = 2, etc.

// Example
// Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
// Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)


public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    Dictionary<string, string> hashMap = new Dictionary<string, string>();

    for(char i = 'A'; i <= 'Z'; i++) {
      string val = (i - 'A' + 1).ToString();
      hashMap.Add(i.ToString(), val);
    }

    List<string> result = new List<string>();

    for(int i = 0; i < text.Length; i++)
    {
      string str = text[i].ToString();
      if(hashMap.ContainsKey(str))
        result.Add(hashMap[str]);
    else if(hashMap.ContainsKey(str.ToUpper()))
        result.Add(hashMap[str.ToUpper()]);
    }
    return String.Join(" ", result.ToArray());;
  }
}

// Optimized solution found

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
  }
}