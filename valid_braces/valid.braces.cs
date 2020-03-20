using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    public static bool validBraces(String braces) {
      List<char> check = new List<char>();

      for(int i = 0; i < braces.Length; i++){
        if(braces[i] == '(' || braces[i] == '[' || braces[i] == '{'){
          check.Add(braces[i]);
          }
        else{
          if(check.Count == 0) return false;
          if(braces[i] == ')') {
            if(check[check.Count - 1] == '(')
              check.RemoveAt(check.Count - 1);
            else return false;
          }
          else if(braces[i] == ']') {
            if(check[check.Count - 1] == '[')
              check.RemoveAt(check.Count - 1);
            else return false;
          }
          else if(braces[i] == '}') {
            if(check[check.Count - 1] == '{')
              check.RemoveAt(check.Count - 1);
            else return false;
          }
        }
      }
      return check.Count == 0 ? true : false;
    }
}