using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class frmSolver : Form
    {
        
        private int[] xMoves = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        private int[] yMoves = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        int[,] board;
        int knightCount = 0;
        List<Tuple<int, int>> userKnight = new List<Tuple<int, int>>();

        bool PutKnight(int x, int y, int moveNumber)
        {
            PictureBox temp, temp_1;
            if (moveNumber > boardSize * boardSize)
            {
                cnt = false;
                MessageBox.Show("Hoàn tất");
                openStopForm();
            }

            else if(cnt)
            {
                List<Tuple<int, int>> possibleMoves = GetPossibleMoves(x, y);

                if (possibleMoves.Count == 0)
                {
                    return false;
                }

                possibleMoves.Sort((a, b) =>
                {
                    int aMoves = GetPossibleMoves(a.Item1, a.Item2).Count;
                    int bMoves = GetPossibleMoves(b.Item1, b.Item2).Count;
                    return aMoves.CompareTo(bMoves);
                });

                foreach (Tuple<int, int> move in possibleMoves)
                {
                    int nextX = move.Item1;
                    int nextY = move.Item2;
                    temp = createChess("knight", nextX, nextY);
                    temp_1 = new PictureBox();
                    Bitmap bm = new Bitmap(cellSize, cellSize);
                    this.Invoke((MethodInvoker)delegate
                    {
                        temp_1.Parent = pbChessBoard;
                    });
                    Font font = new Font("Arial", 22);
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        g.DrawString(moveNumber.ToString(), font, Brushes.Red, 0, 0);
                    }
                    temp_1.Image = bm;
                    this.Invoke((MethodInvoker)delegate
                    {
                        temp.Controls.Add(temp_1);
                        this.Refresh();
                    });

                    board[nextX, nextY] = moveNumber;

                    if (PutKnight(nextX, nextY, moveNumber + 1))
                    {
                        return true;
                    }

                    board[nextX, nextY] = 0;


                    return false;
                }
            }
            return true;
        }
        List<Tuple<int, int>> GetPossibleMoves(int x, int y)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

            for (int i = 0; i < 8; i++)
            {
                int nextX = x + xMoves[i];
                int nextY = y + yMoves[i];

                if (nextX >= 0 && nextX < boardSize && nextY >= 0 && nextY < boardSize && board[nextX, nextY] == 0)
                {
                    moves.Add(new Tuple<int, int>(nextX, nextY));
                }
            }
            return moves;
        }
        bool CanPlaceKnight(int x, int y)
        {
            foreach(Tuple<int,int> knight in GetPossibleMoves(userKnight.Last().Item1, userKnight.Last().Item2))
            {
                if (x == knight.Item1 && y == knight.Item2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
