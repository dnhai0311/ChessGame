using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class frmSolver : Form
    {
        /*
        boardSize là biến để lưu độ lớn của bàn cờ ( số ô cờ trên một hàng/ một cột )
        cellSize là biến để lưu độ lớn của một ô cờ ( chiều dài = chiều rộng )
        squareColor1 là biến để lưu màu sắc của một ô cờ
        squareColor2 là biến để lưu màu sắc của một ô cờ
        queenImg là biến để lưu hình ảnh quân hậu
        knightImg là biến để lưu hình ảnh quân mã
        chessName là biến để xác định khi click chuột sẽ đặt quân gì lên bàn cờ
         */
        int boardSize = 8;
        int boardWidth = 600;
        int cellSize = 600 / 8;
        Brush squareColor1 = Brushes.White;
        Brush squareColor2 = Brushes.Green;
        Image queenImg;
        Image knightImg;
        String chessName = "queen";

        public int getIndex(int pos)
        {
            return pos / cellSize;
        }

        /*
         CreateChessBoard là hàm được dùng để khởi tạo bàn cờ. Với đầu vào là độ lớn của bàn cờ.
        */

        public void createChessBoard(int size)
        {
            boardSize = size;
            cellSize = boardWidth / boardSize;
            board = new int[size, size];
            queens = new int[boardSize];
            userQueens = new int[boardSize];
            knightCount = 0;
            userKnight = new List<Tuple<int, int>>();
            queenImg = ResizeImg("queen");
            knightImg = ResizeImg("knight");
            initUserQueens();

            Bitmap bm = new Bitmap(cellSize * boardSize, cellSize * boardSize);
            using (Graphics g = Graphics.FromImage(bm))
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                            g.FillRectangle(squareColor1, i * cellSize, j * cellSize, cellSize, cellSize);
                        else
                            g.FillRectangle(squareColor2, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
            pbChessBoard.BackgroundImage = bm;
            pbChessBoard.Invoke((MethodInvoker)delegate
            {
                pbChessBoard.Controls.Clear();
            });
            }

        /*
        resizeImg là hàm để điều chỉnh kích thước của hình ảnh quân hậu/ mã để phù hợp với kích thước hiện tại của bằn cờ.
        */
        Image ResizeImg(string name)
        {
            Image img;
            if(name == "queen")
            {
                img = Image.FromFile("..//..//img//queen.png");
            }
            else
            {
                img = Image.FromFile("..//..//img//knight.png");
            }
            Image resizeImage = new Bitmap(cellSize, cellSize);
            using (Graphics g = Graphics.FromImage(resizeImage))
            {
                g.DrawImage(img, new Rectangle(Point.Empty, new Size(cellSize, cellSize)));
            }
            return resizeImage;
        }

        public PictureBox createChess(string chess, int cot, int hang)
        {
            PictureBox Chess = new PictureBox();
            this.Invoke((MethodInvoker)delegate
           {
               pbChessBoard.Controls.Add(Chess);
               Chess.Parent = pbChessBoard;
               Chess.Size = new Size(cellSize, cellSize);
               Chess.Location = new Point(cot * cellSize, hang * cellSize);
               if (chessName == "queen")
               {
                   Chess.BackgroundImage = queenImg;
               }
               else
               {
                   Chess.BackgroundImage = knightImg;
               }
               Chess.BackColor = Color.Transparent;
               this.Refresh();
           });
            Chess.MouseDown += (sender, e) =>
            {
                mousePos = e.Location;
                mousePos = pbChessBoard.PointToClient(Chess.PointToScreen(mousePos));
                if (chessName == "queen")
                {
                    userQueens[getIndex(mousePos.Y)] = -100;
                    pbChessBoard.Controls.Remove(Chess);
                    Chess.Dispose();
                }
                else
                {
                    userKnight.Remove(new Tuple<int, int>(getIndex(mousePos.X), getIndex(mousePos.Y)));
                    board[getIndex(mousePos.X), getIndex(mousePos.Y)] = 0;
                    knightCount--;
                }
                pbChessBoard.Controls.Remove(Chess);
                Chess.Dispose();
            };
            return Chess;
        }

    }
}
