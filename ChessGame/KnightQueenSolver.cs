using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class frmSolver : Form
    {
        Point mousePos;
        public static bool cnt = true;
        public frmSolver()
        {
            InitializeComponent();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            
            int size = int.Parse(txtSizeBoard.Text);
            createChessBoard(size);
        }

        private void btnQueen_Click(object sender, EventArgs e)
        {
            btnQueen.BackColor = Color.Green;
            btnKnight.BackColor = Color.White;
            chessName = "queen";
            createChessBoard(boardSize);
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            btnQueen.BackColor = Color.White;
            btnKnight.BackColor = Color.Green;
            chessName = "knight";
            createChessBoard(boardSize);
        }

        private void pbChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            mousePos = e.Location;
            PictureBox temp = createChess(chessName, getIndex(mousePos.X), getIndex(mousePos.Y));
            if (chessName == "queen")
            {
                if (userQueens[getIndex(mousePos.Y)] >= 0)
                {
                    MessageBox.Show("Không thể đặt quân hậu lên bàn cờ 1");
                    temp.Dispose();
                    return;
                }
                if (!isQueenSafe(getIndex(mousePos.Y), getIndex(mousePos.X), userQueens))
                {
                    MessageBox.Show("Không thể đặt quân hậu lên bàn cờ 2");
                    temp.Dispose();
                    return;
                }
                userQueens[getIndex(mousePos.Y)] = getIndex(mousePos.X);
            }
            else
            {

                if (userKnight.Count > 0 && !CanPlaceKnight(getIndex(mousePos.X), getIndex(mousePos.Y)))
                {
                    MessageBox.Show("Không thể đặt quân mã lên bàn cờ");
                    temp.Dispose();
                    return;
                }
                board[getIndex(mousePos.X), getIndex(mousePos.Y)] = ++knightCount;
                userKnight.Add(new Tuple<int, int>(getIndex(mousePos.X), getIndex(mousePos.Y)));
            }

        }

        void openStopForm()
        {
            this.Invoke((MethodInvoker)delegate
            {
                btnStop.Enabled = false;
                Thread thread;
                if (chessName =="queen")
                {
                    thread = new Thread(() =>
                    {
                        Application.Run(new StopForm(this.Location, queens));
                    });
                }
                else
                {
                    thread = new Thread(() =>
                    {
                        Application.Run(new StopForm(this.Location, board));
                    });
                }
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
                btnStop.Enabled = true;
            });
        }

        void setButton(bool status)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if(status)
                {
                    pbChessBoard.Controls.Clear();
                }
                btnStop.Visible = !status;
                gbSizeSetting.Enabled = status;
                btnSolve.Enabled = status;
                btnSolveIcon.Enabled = status;
                btnQueen.Enabled = status;
                btnKnight.Enabled = status;
                pbChessBoard.Enabled = status;
                btnSave.Enabled = status;
                btnOpen.Enabled = status;
            });
        }

        void solveQueen()
        {
            cnt = true;
            PutQueen(0);
            if (cnt)
            {
                MessageBox.Show("Không còn trường hợp nào khác");
            }
            initUserQueens();
            setButton(true);
        }

        void solveKnight()
        {
            cnt = true;
            int x = getIndex(mousePos.X);
            int y = getIndex(mousePos.Y);
            if (userKnight.Count() > 0)
            {
                x = userKnight.Last().Item1;
                y = userKnight.Last().Item2;
            }
            else if (userKnight.Count == 0)
            {
                Random r = new Random();
                x = r.Next(0, boardSize - 1);
                y = r.Next(0, boardSize - 1);
                PictureBox temp = createChess("knight", x, y);
                knightCount++;
                board[x, y] = 1;
            }
            if(!PutKnight(x, y, knightCount+1))
            {
                MessageBox.Show("Không có lời giải");
            }
            int size = int.Parse(txtSizeBoard.Text);
            createChessBoard(size);
            setButton(true);
            knightCount = 0;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            setButton(false);
            if (chessName == "queen")
            {
                if(boardSize < 4)
                {
                    MessageBox.Show("Không thể giải với chiều dài bàn cờ nhỏ hơn 4");
                    setButton(true);
                }
                else
                {
                    Thread thread = new Thread(solveQueen);
                    thread.Start();
                }
            }
            else
            {
                if (boardSize < 5)
                {
                    MessageBox.Show("Không thể giải với chiều dài bàn cờ nhỏ hơn 5");
                    setButton(true);
                }
                else
                {
                    Thread thread = new Thread(solveKnight);
                    thread.Start();
                }
            }
        }

        private void btnSolve_MouseHover(object sender, EventArgs e)
        {
            btnSolve.ForeColor = Color.Green;
            btnSolve.FlatAppearance.BorderColor = Color.Green;
        }

        private void btnSolve_MouseLeave(object sender, EventArgs e)
        {
            btnSolve.ForeColor = Color.Black;
            btnSolve.FlatAppearance.BorderColor = Color.Black;
        }

        private void pbChessBoard_MouseMove(object sender, MouseEventArgs e)
        {
            //mousePos = e.Location;
        }

        private void frmChessGame_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            createChessBoard(8);
        }

        private void txtSizeBoard_TextChanged(object sender, EventArgs e)
        {
            string text = txtSizeBoard.Text;
            if(text!="")
            {
                try
                {
                    int size = int.Parse(text);
                    createChessBoard(size);
                }
                catch
                {
                    txtSizeBoard.Clear();
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
        }

        private void txtSizeBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                createChessBoard(int.Parse(txtSizeBoard.Text));
                pbChessBoard.Controls.Clear();
            }
        }

        private void Stop()
        {
            btnStop.Enabled = false;
            if (chessName == "knight")
            {
                Thread thread = new Thread(() =>
                {
                    Application.Run(new StopForm(this.Location));
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            else
            {
                cnt = false;
            }
            if (cnt == false)
            {
                pbChessBoard.Controls.Clear();
            }
            btnStop.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Save()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"TXT|*.txt" })
            {
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                using (TextWriter tw = new StreamWriter(saveFileDialog.FileName))
                {
                    tw.WriteLine(chessName);
                    tw.WriteLine(txtSizeBoard.Text);
                    if (chessName == "queen")
                    {
                        foreach (int item in userQueens)
                        {
                            tw.Write(item.ToString() + " ");
                        }
                    }
                    else if (chessName == "knight")
                    {
                        foreach (Tuple<int, int> item in userKnight)
                        {
                            tw.Write(item.Item1.ToString() + " " + item.Item2.ToString());
                            tw.Write("\n");
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Open()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                StreamReader file = new StreamReader(openDialog.FileName);
                string type = file.ReadLine();
                int size = int.Parse(file.ReadLine());
                txtSizeBoard.Text = (size).ToString();
                createChessBoard(size);
                if (type == "queen")
                {
                    btnQueen.PerformClick();
                    string line = file.ReadLine();
                    string[] parts = line.Split(' ');
                    for (int i = 0; i < size - 1; i++)
                    {
                        userQueens[i] = int.Parse(parts[i]);
                        createChess(type, userQueens[i], i);
                    }
                }
                else if (type == "knight")
                {
                    btnKnight.PerformClick();
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] parts = line.Split(' ');
                        userKnight.Add(new Tuple<int, int>(int.Parse(parts[0]), int.Parse(parts[1])));
                        board[int.Parse(parts[0]), int.Parse(parts[1])] = ++knightCount;
                        createChess(type, int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("File không hợp lệ");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void frmSolver_Load(object sender, EventArgs e)
        {
            createChessBoard(8);
            this.MaximumSize = this.Size;
        }
    }
}
