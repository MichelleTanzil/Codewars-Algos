using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    string str = s.ToLower();
    Dictionary<char, int> hashMap = new Dictionary<char, int>();
    for (int i = 0; i < str.Length; i++)
    {
      if (hashMap.ContainsKey(str[i])) hashMap[str[i]]++;
      else hashMap[str[i]] = 1;
    }
    for (int i = 0; i < s.Length; i++)
    {
      if (hashMap[char.ToLower(s[i])] == 1) return s[i].ToString();
    }
    return "";
  }
}

//Optimized Solution
public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
  }
}