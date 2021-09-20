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
      return enemyX == XCoord || enemyY == YCoord;
    }

    public bool canAttackDiagonal(int enemyX, int enemyY)
    {
      /*
        Queen: 1,1
        Enemy: 3,3
      */
      int shiftH = Math.Abs(enemyX - XCoord);
      int shiftV = Math.Abs(enemyY - YCoord);
      return shiftH == shiftV;
      /*
        Queen: 1,3
        Enemy: 3,1
        shiftH = 2;
        shiftV = -2;
      */
      
    }
  }
  
}