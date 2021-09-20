using System;
using System.Collections.Generic;
using QueenAttack.Models;

namespace QueenAttack
{
  public class Program
  {
    public static void Main()
    {
      int checkInput(string input)
      {
        int finalInput;
        try 
        {
          finalInput = int.Parse(input);
        }
        catch
        {
          Console.WriteLine($"Sorry, please enter an integer");
          string newInput = Console.ReadLine();
          finalInput = checkInput(newInput);
        }
        return finalInput;
      }
      // define coords area? Like, how large of a "space" there is? The board, I guess, haha.
      //set starting coords for Queen & other piece [maybe we just hardcode this for testing purposes, but then set it up so User enters them]
      //
      Console.WriteLine($"Enter the Queen's X coordinate (1-8): ");
      string queenXString = Console.ReadLine();
      int queenX = checkInput(queenXString);

      Console.WriteLine($"Enter the Queen's Y coordinate (1-8): ");
      string queenYString = Console.ReadLine();
      int queenY = checkInput(queenYString);

      Console.WriteLine($"Enter the enemy piece's X coordinate (1-8): ");
      string enemyXString = Console.ReadLine();
      int enemyX = checkInput(enemyXString);

      Console.WriteLine($"Enter the enemy piece's Y coordinate (1-8): ");
      string enemyYString = Console.ReadLine();
      int enemyY = checkInput(enemyYString);

      if (queenX == enemyX && queenY == enemyY)
      {
        Console.WriteLine("Sorry, 2 pieces cannot occupy the same square.");
        Main();
      }

      Queen myQueen = new Queen(queenX, queenY);

      //same square
      
      //not an int
      //int out of range

      if (myQueen.canAttackVH(enemyX, enemyY) || myQueen.canAttackDiagonal(enemyX, enemyY))
      {
        Console.WriteLine("The queen can attack the enemy piece.");
      }
      else
      {
        Console.WriteLine($"The queen cannot attack the enemy piece.");
        
      }
    }
  }
}
/*
C:\Users\natha\Desktop\epicodus\cs\QueenAttack\Models\Queen.cs(19,24): error CS0103: The name 'xCoord' does not exist in the current context [C:\Users\natha\Desktop\epicodus\cs\QueenAttack\QueenAttack.csproj]
C:\Users\natha\Desktop\epicodus\cs\QueenAttack\Models\Queen.cs(19,44): error CS0103: The name 'yCoord' does not exist in the current context [C:\Users\natha\Desktop\epicodus\cs\QueenAttack\QueenAttack.csproj]
C:\Users\natha\Desktop\epicodus\cs\QueenAttack\Models\Queen.cs(28,38): error CS0103: The name 'queenX' does not exist in the current context [C:\Users\natha\Desktop\epicodus\cs\QueenAttack\QueenAttack.csproj]
C:\Users\natha\Desktop\epicodus\cs\QueenAttack\Models\Queen.cs(29,38): error CS0103: The name 'queenY' does not exist in the current context [C:\Users\natha\Desktop\epicodus\cs\QueenAttack\QueenAttack.csproj]

*/
