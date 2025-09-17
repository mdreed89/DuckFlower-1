/*
Duck-Flower Coding Challenge
Objective
Write a C# program that prints the numbers from 1 to 100.
However:

For numbers divisible by 3, print "Duck" instead of the number.

For numbers divisible by 5, print "Flower" instead of the number.

For numbers divisible by both 3 and 5, print "DuckFlower" instead of the number.

Requirements
Your program should loop from 1 to 100 (inclusive).

Each output should be printed on a new line.

The program should correctly substitute words according to the rules above.

The solution should be written in C# and be self-contained (no dependencies other than standard .NET libraries).
 */
 
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 1; i <= 100; i++) 
      {
      if (i % 3 == 0 && i % 5 == 0) {
      	Console.WriteLine("DuckFlower");
      }
      else if (i % 3 == 0) {
      	Console.WriteLine("Duck");
      }
      else if (i % 5 == 0) {
      	Console.WriteLine("Flower");
      }
      else {
      	Console.WriteLine(i);
      }
   
      }    
    }
  }
}