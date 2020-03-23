using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    int[] arr = numbers.Split(" ").Select(int.Parse).ToArray();
    return arr.Max() + " " + arr.Min();
  }
}