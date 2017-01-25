using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170124
{
    public class Minesweeper
    {
        private bool[,] board;


        public Minesweeper(bool[,] board)
        {
            this.board = board;
        }

        public bool IsBomb(int x, int y)
        {
            if (IsntInRange(x, 0, board.GetLength(0)) || IsntInRange(y, 0, board.GetLength(1)))
                return false;
            return board[x, y];
        }

        private static bool IsntInRange(int index, int min, int max)
        {
            return index < min || index >= max;
        }

        public int GetCellScore(int x, int y)
        {
            var numberOfBombs = 0;
            for (var i = x - 1; i <= x + 1; i++)
            {
                for (var j = y - 1; j <= y + 1; j++)
                {
                    if (i == x && j == y)
                    {
                    }
                    if (IsBomb(i, j))
                    {
                        numberOfBombs++;
                    }
                }
            }
            return numberOfBombs;
        }
    }
}

