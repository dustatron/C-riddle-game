using System;

class Program 
{
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
      Riddle();
    }
    else
    {
      Console.WriteLine("So long traveler");
    }
  }

  static void Riddle()
  {
    Console.WriteLine("What has no door, hinge, key, or lid, but a golden treasure inside in hid?");
    string answer = Console.ReadLine();
    if (answer == "egg" || answer == "an egg")
    {
      Console.WriteLine("Super job traveler!");
    }
    else
    {
      Console.WriteLine("NOPE! the answer was 'an Egg'");
      Console.WriteLine("I don't want to say you suck, but if the shoe fits...");
    }
  }
}