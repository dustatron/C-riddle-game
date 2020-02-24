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

    if(toStart == 'y' || toStart == 'Y')
    {
      //start game
      Riddle();
    }
    else
    {
      Console.WriteLine("So long traveler");
    }
  }

  static voic Riddle()
  {
    Console.WriteLine("Riddle Test");
  }
}