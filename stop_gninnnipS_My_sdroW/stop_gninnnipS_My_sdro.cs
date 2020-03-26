using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    List<string> result = new List<string>();
    var input = sentence.Split(" ");
    foreach (string word in input)
    {

      if (word.Length < 5) result.Add(word.ToString());
      else
      {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        result.Add(reversed);
      }
    }
    return String.Join(" ", result);
  }
}
//Optimized Solution
public class Kata
{
  public static string SpinWords(string sentence)
  {
    return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
  }
}