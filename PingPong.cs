using System;
using System.Collections.Generic;

namespace PingPong.Models 
{
  public class PingPong
  {
    public static string MakeList(int number) 
    {
      List<string> pingPong = new List<string> {};
      for(int index = 0; index < number; index ++)
      {
        int currentNumber = index + 1;
        if (currentNumber % 3 == 0 && currentNumber % 5 == 0) 
        {
          pingPong[index] = "ping-pong";
        }
        else if (currentNumber % 5 == 0) 
        {
          pingPong[index] = "pong";
        }
        else if (currentNumber % 3 == 0) 
        {
          pingPong[index] = "ping";
        }
        else 
        {
          pingPong[index] = currentNumber.ToString();
        }
      }
      string stringPingPong = string.Join( ",", pingPong);
      return stringPingPong;
    }
  }
}