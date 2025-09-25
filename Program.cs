using System;
namespace MyApplication;

class Program
{
  static void Main(string[] args)
  {
    int number;
    while (true)
    {
      Console.WriteLine("Please enter a number between 1 and 100:");
      string userInput = Console.ReadLine();

      if (int.TryParse(userInput, out number) && number >= 1 && number <= 100)
      {
        DuckFlowerApp.Run(number);
        break;
      }
      else Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
    }
  }
}
/*
Add a do-while loop: 
First time, user is asked to enter a number. 
After the while loop ends, ask user if they want to enter another number. - Validate reponse
Repeat loop until user responds 'n'.

*/