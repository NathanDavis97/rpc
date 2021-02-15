using System;
using System.Collections.Generic;
using System.Threading;
using rpc.models;

namespace rpc
{
    class Program
    {
    static void Main(string[] args)
    {
      bool running = true;
      while (running)
      { 

        Console.WriteLine("\n Hello Challenger!");
        Console.WriteLine("Please choose rock, paper, or scissors. Q to escape");
        string name = Console.ReadLine();
        
        Random rnd = new Random();
        string[] OppChoice = new string[3];
        OppChoice[0] = "rock";
        OppChoice[1] = "paper";
        OppChoice[2] = "scissors";
        int oInd = rnd.Next(OppChoice.Length);
        string vs = OppChoice[oInd];
        Console.WriteLine("\n You have chosen " + name);
        Console.WriteLine("\n Opponents choice is " + vs);
        if (name == "rock")
        {
          if (name == vs)
          {
            Console.WriteLine("You have tied");
          }
          else if (vs == "paper")
          {
            Console.WriteLine("your opponent has won");
          }
          else
          {
            Console.WriteLine("Congratulations! You have won!");
          }
        }
        else if (name == "scissors")
        {
          if (name == vs)
          {
            Console.WriteLine("You have tied");
          }
          else if (vs == "rock")
          {
            Console.WriteLine("your opponent has won");
          }
          else
          {
            Console.WriteLine("Congratulations! You have won!");
          }
        }
        else if (name == "paper")
        {
          if (name == vs)
          {
            Console.WriteLine("You have tied");
          }
          else if (vs == "scissors")
          {
            Console.WriteLine("your opponent has won");
          }
          else
          {
            Console.WriteLine("Congratulations! You have won!");
          }
        }
        else if (name ==  "Q")
        {
running = false;
System.Console.WriteLine("Thanks for playing!");
        }
        else System.Console.WriteLine("something went wrong, try again");
      }
    }
  }
}
