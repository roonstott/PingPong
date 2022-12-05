using System;
using System.Collections.Generic;
using PingPong.Models;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("ENTER A NUMBER");
    string stringNumber = Console.ReadLine();
    int number = int.Parse(stringNumber);
    
    string stringOutput = PingPong.MakeList(number);
    Console.WriteLine(stringOutput);

    // foreach (string entry in pingPong)
    // {
    //   Console.WriteLine(entry);
    // }
  }
}