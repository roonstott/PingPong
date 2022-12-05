using System;
using System.Collections.Generic;

namespace Models 
{
  public class PingPong
  {
    public static string MakeList(int number) 
    {
      List<string> pingPong = new List<string>(0);
      for(int index = 0; index < number; index++)
      {
        int currentNumber = index + 1;
        if (currentNumber % 3 == 0 && currentNumber % 5 == 0) 
        {
          pingPong.Add("ping-pong");
        }
        else if (currentNumber % 5 == 0) 
        {
          pingPong.Add("pong");
        }
        else if (currentNumber % 3 == 0) 
        {
          pingPong.Add("ping");
        }
        else 
        {
          pingPong.Add(currentNumber.ToString());
        }
      }
      string stringPingPong = string.Join( ",", pingPong);
      return stringPingPong;
    }
  }
}