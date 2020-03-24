using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> result = new List<string>();
    string wordToCheck = String.Concat(word.OrderBy(c => c));
    for (int i = 0; i < words.Count; i++) {
      string str = String.Concat(words[i].OrderBy(c => c));
      if(wordToCheck == str) result.Add(words[i]);
    }
    return result;
  }
}

//Optimizied Solution

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    var pattern = word.OrderBy(p => p).ToArray();
    return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
  }
}