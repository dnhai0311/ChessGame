
namespace ChessGame
{
    partial class frmSolver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolver));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSolveIcon = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnKnight = new System.Windows.Forms.Button();
            this.btnQueen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbSizeSetting = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtSizeBoard = new System.Windows.Forms.TextBox();
            this.pbChessBoard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbSizeSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSolveIcon);
            this.panel1.Controls.Add(this.btnSolve);
            this.panel1.Controls.Add(this.btnKnight);
            this.panel1.Controls.Add(this.btnQueen);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.gbSizeSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(613, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 613);
            this.panel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpen.Location = new System.Drawing.Point(79, 467);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 33);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Mở bàn cờ";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(79, 520);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu bàn cờ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 87);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chess Game";
            // 
            // btnSolveIcon
            // 
            this.btnSolveIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnSolveIcon.BackgroundImage = global::ChessGame.Properties.Resources.solve;
            this.btnSolveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolveIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolveIcon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSolveIcon.FlatAppearance.BorderSize = 0;
            this.btnSolveIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSolveIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSolveIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolveIcon.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSolveIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSolveIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSolveIcon.Location = new System.Drawing.Point(61, 343);
            this.btnSolveIcon.Name = "btnSolveIcon";
            this.btnSolveIcon.Size = new System.Drawing.Size(58, 54);
            this.btnSolveIcon.TabIndex = 13;
            this.btnSolveIcon.UseVisualStyleBackColor = false;
            this.btnSolveIcon.Click += new System.EventHandler(this.btnSolve_Click);
            this.btnSolveIcon.MouseLeave += new System.EventHandler(this.btnSolve_MouseLeave);
            this.btnSolveIcon.MouseHover += new System.EventHandler(this.btnSolve_MouseHover);
            // 
            // btnSolve
            // 
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSolve.Location = new System.Drawing.Point(54, 335);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(209, 70);
            this.btnSolve.TabIndex = 12;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            this.btnSolve.MouseLeave += new System.EventHandler(this.btnSolve_MouseLeave);
            this.btnSolve.MouseHover += new System.EventHandler(this.btnSolve_MouseHover);
            // 
            // btnKnight
            // 
            this.btnKnight.BackColor = System.Drawing.Color.White;
            this.btnKnight.BackgroundImage = global::ChessGame.Properties.Resources.knight;
            this.btnKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKnight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnight.Location = new System.Drawing.Point(165, 200);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(120, 114);
            this.btnKnight.TabIndex = 11;
            this.btnKnight.UseVisualStyleBackColor = false;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnQueen
            // 
            this.btnQueen.BackColor = System.Drawing.Color.Green;
            this.btnQueen.BackgroundImage = global::ChessGame.Properties.Resources.queen;
            this.btnQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQueen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueen.Location = new System.Drawing.Point(31, 200);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(120, 114);
            this.btnQueen.TabIndex = 10;
            this.btnQueen.UseVisualStyleBackColor = false;
            this.btnQueen.Click += new System.EventHandler(this.btnQueen_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(18, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 38);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbSizeSetting
            // 
            this.gbSizeSetting.Controls.Add(this.btnReload);
            this.gbSizeSetting.Controls.Add(this.txtSizeBoard);
            this.gbSizeSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbSizeSetting.Location = new System.Drawing.Point(166, 12);
            this.gbSizeSetting.Name = "gbSizeSetting";
            this.gbSizeSetting.Size = new System.Drawing.Size(134, 54);
            this.gbSizeSetting.TabIndex = 8;
            this.gbSizeSetting.TabStop = false;
            this.gbSizeSetting.Text = "Size";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.BackgroundImage = global::ChessGame.Properties.Resources.reload;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(91, 19);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 1;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // txtSizeBoard
            // 
            this.txtSizeBoard.Location = new System.Drawing.Point(14, 23);
            this.txtSizeBoard.Name = "txtSizeBoard";
            this.txtSizeBoard.Size = new System.Drawing.Size(71, 30);
            this.txtSizeBoard.TabIndex = 0;
            this.txtSizeBoard.Text = "8";
            this.txtSizeBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSizeBoard.TextChanged += new System.EventHandler(this.txtSizeBoard_TextChanged);
            this.txtSizeBoard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSizeBoard_KeyDown);
            // 
            // pbChessBoard
            // 
            this.pbChessBoard.Location = new System.Drawing.Point(6, 7);
            this.pbChessBoard.Name = "pbChessBoard";
            this.pbChessBoard.Size = new System.Drawing.Size(600, 600);
            this.pbChessBoard.TabIndex = 0;
            this.pbChessBoard.TabStop = false;
            this.pbChessBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbChessBoard_MouseDown);
            // 
            // frmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbChessBoard);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSolver_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSizeSetting.ResumeLayout(false);
            this.gbSizeSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChessBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSolveIcon;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnQueen;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox gbSizeSetting;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSizeBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pbChessBoard;
    }
}

