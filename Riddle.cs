using System;
using System.Collections.Generic;
// using System.Serializable;

class Program 
{
  public static Dictionary<int,string[]> riddleBook = new Dictionary<int,string[]>()
  {
    {1, new string[] {"What has to be broken before you can use it?", "An egg"}},
    {2, new string[] {"I’m tall when I’m young, and I’m short when I’m old. What am I?", "A candle"}},
    {3, new string[] {"What month of the year has 28 days?", "All of them"}},
    {4, new string[] {"What is full of holes but still holds water?", "A sponge"}},
    {5, new string[] {"What question can you never answer yes to?", "Are you asleep yet?"}},
  };
  // riddleBook.Add("q1","question");

  static void Main()
  {
    Console.WriteLine("Welcome young traveler!");
    Console.WriteLine("If you wish to pass you must answer my riddles!");
    Console.WriteLine("Are you ready for the first riddle?");
    Console.WriteLine("Press 'Y' to start or return to 'Enter' to quit. ");
    string toStart = Console.ReadLine();

    if(toStart == "y" || toStart == "Y")
    {
      //start game
      AskRiddle();
    }
    else
    {
      Console.WriteLine("So long traveler");
    }
  }

  static void AskRiddle()
  {
    var rand = new Random();
    int index = rand.Next(5);

    Console.WriteLine(riddleBook[index][0]);
    string answer = Console.ReadLine();
    if (answer == riddleBook[index][1])
    {
      Console.WriteLine();
      Console.WriteLine("------------------------------------------");
      Console.WriteLine("Super job traveler!");
      Console.WriteLine("Care to answer another riddle?");
      Console.WriteLine("Press 'Y' to start or return to 'Enter' to quit. ");
      string input = Console.ReadLine();

      if(input == "Y" || input == "y")
      {
        AskRiddle();
      }
      else
      {
        Console.WriteLine("So long traveler");
      }
    }
    else
    {
      Console.WriteLine();
      Console.WriteLine("--------------------------------------");
      Console.WriteLine("NOPE! the answer was " + riddleBook[index][1]);
      Console.WriteLine("I don't want to say you suck, but if the shoe fits...");
      Console.WriteLine();
      Console.WriteLine("Care to answer another riddle?");
      Console.WriteLine("Press 'Y' to start or return to 'Enter' to quit. ");
      string input = Console.ReadLine();

      if(input == "Y" || input == "y")
      {
        AskRiddle();
      }
      else
      {
        Console.WriteLine("So long traveler");
      }
    }
  }

}