using System;
namespace MyApplication;

public static class DuckFlowerApp
{
    public static void UserInputDF()
    {
        NumberInputHandler();
    }

    public static void NumberInputHandler()
    {
            Console.WriteLine("Please enter a number between 1 and 100:");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number) && number >= 1 && number <= 100)
            {
                DuckFlowerApp.ReturnDuckFlowerValue(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
                NumberInputHandler();
            }

        PlayAgainHandler();
    }

    public static void PlayAgainHandler()
    {

        Console.WriteLine("Do you want to play again (Y/N)?"); // make a do while, copy number validation logic
        string input = Console.ReadLine();


        if (input.Trim().ToLower() == "y")
        {
            NumberInputHandler();
        }
        else if (input.Trim().ToLower() == "n") Console.WriteLine("Thanks for playing!");
        else
        {
            Console.WriteLine("Invalid input. ");
            PlayAgainHandler(); // This is a recursive call (try not to do this!)
        }
    }

    public static void DefaultDF()
    {
        // create default DF logic where it prints out 1-100 (for loop)
    }

    public static void ReturnDuckFlowerValue(int number)
    {


        if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("DuckFlower");
        else if (number % 3 == 0) Console.WriteLine("Duck");
        else if (number % 5 == 0) Console.WriteLine("Flower");
        else Console.WriteLine(number);

    }
}
