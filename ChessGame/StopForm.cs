using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class StopForm : Form
    {
        int[] queens;
        int[,] board;

        public StopForm(Point location)
        {
            InitializeComponent();
            this.Location = new Point(location.X + 642, location.Y + 440);
        }
        public StopForm(Point location, int[] queens)
        {
            InitializeComponent();
            this.Location = new Point(location.X+642, location.Y+440);
            this.queens = queens;
        }
        public StopForm(Point location, int[,] board)
        {
            InitializeComponent();
            this.Location = new Point(location.X + 642, location.Y + 440);
            this.board = board;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            frmSolver.cnt = false;
            this.Close();
        }

        private void StopForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (queens == null && board == null)
            {
                MessageBox.Show("Không thể in kết quả");
                return;
            }
            PrintSolution();
        }
        
        private void PrintSolution()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"TXT|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)

                {
                    using (System.IO.TextWriter tw = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        if (queens == null)
                        {
                            int count = 0;
                            foreach (int item in board)
                            {
                                tw.Write(item.ToString() + "\t");
                                if (Math.Sqrt(board.Length) - 1 == count++)
                                {
                                    tw.Write("\n");
                                    count = 0;
                                }
                            }
                        }
                        else
                        {
                            int count = 0;
                            foreach (int item in queens)
                            {
                                tw.Write("Hậu đứng ở hàng " + ++count + " cột " + (item + 1).ToString());
                                tw.Write("\n");
                            }
                        }
                    }
                }
            }
        }
    }
}
