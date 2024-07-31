using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace ChessGame
{
    public partial class frmSolver : Form
    {
        private int[] queens;
        private int[] userQueens;
        public void initUserQueens()
        {
            for(int i=0; i < userQueens.Length; i++)
            {
                userQueens[i] = -100;
            }
        }
        void PutQueen(int row)
        {
            if (row == boardSize)
            {
                openStopForm();
                return;
            }
            else if (cnt)
                if(userQueens[row] >= 0)
                {
                    if(isQueenSafe(row, userQueens[row]))
                    {
                        queens[row] = userQueens[row];
                    }
                    else
                    {
                        return;
                    }
                    PutQueen(row + 1);
                }
            else
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        
                        if (isQueenSafe(row,col))
                        {
                            queens[row] = col;
                            PictureBox temp = createChess("queen", col, row);
                            
                            PutQueen(row + 1);
                            this.Invoke((MethodInvoker)delegate
                            {
                                temp.Dispose();
                            });
                        }
                    }
                }
        }

        bool isQueenSafe(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (queens[i] == col || Math.Abs(i - row) == Math.Abs(queens[i] - col))
                    return false;
            }

            return true;
        }
        bool isQueenSafe(int row, int col, int[] queens)
        {
            for (int i = 0; i < boardSize; i++)
            {
                if (queens[i] == col || Math.Abs(i - row) == Math.Abs(queens[i] - col))
                    return false;
            }
            return true;
        }
    }
}
