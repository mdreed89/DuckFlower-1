using System;
namespace MyApplication;

public static class DuckFlowerApp
{
    public static void Run(int number)
    {

        if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("DuckFlower");
        else if (number % 3 == 0) Console.WriteLine("Duck");
        else if (number % 5 == 0) Console.WriteLine("Flower");
        else Console.WriteLine(number);

    }
}
