using System;
using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Queen
  {
    public int XCoord { get; set;}
    public int YCoord { get; set;}

    public Queen(int xCoord, int yCoord)
    {
      XCoord = xCoord;
      YCoord = yCoord;
    }

    public bool canAttackVH(int enemyX, int enemyY)
    {
      return enemyX == xCoord || enemyY == yCoord;
    }

    public bool canAttackDiagonal(int enemyX, int enemyY)
    {
      /*
        Queen: 1,3
        Enemy: 3,1
      */
    }
  }
  
}