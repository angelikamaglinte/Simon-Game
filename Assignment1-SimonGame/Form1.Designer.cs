namespace Assignment1_SimonGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxGame = new PictureBox();
            btnStart = new Button();
            lblScore = new Label();
            timerAssign = new System.Windows.Forms.Timer(components);
            timerRead = new System.Windows.Forms.Timer(components);
            listBoxHighScores = new ListBox();
            label1 = new Label();
            btnInstructions = new Button();
            btnExitGame = new Button();
            timerFlash = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxGame.Image = Properties.Resources.Simon;
            pictureBoxGame.Location = new Point(30, 134);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(701, 620);
            pictureBoxGame.TabIndex = 0;
            pictureBoxGame.TabStop = false;
            pictureBoxGame.MouseDown += pictureBoxGame_MouseDown;
            pictureBoxGame.MouseUp += pictureBoxGame_MouseUp;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Yellow;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(312, 57);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(145, 46);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(30, 14);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(100, 32);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            // 
            // timerAssign
            // 
            timerAssign.Interval = 750;
            timerAssign.Tick += timerAssign_Tick;
            // 
            // timerRead
            // 
            timerRead.Interval = 1000;
            timerRead.Tick += timerRead_Tick;
            // 
            // listBoxHighScores
            // 
            listBoxHighScores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxHighScores.BackColor = Color.Black;
            listBoxHighScores.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxHighScores.ForeColor = Color.White;
            listBoxHighScores.FormattingEnabled = true;
            listBoxHighScores.ItemHeight = 30;
            listBoxHighScores.Location = new Point(792, 180);
            listBoxHighScores.Name = "listBoxHighScores";
            listBoxHighScores.Size = new Size(338, 574);
            listBoxHighScores.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(985, 134);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 4;
            label1.Text = "Score board";
            // 
            // btnInstructions
            // 
            btnInstructions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInstructions.BackColor = Color.Blue;
            btnInstructions.FlatStyle = FlatStyle.Popup;
            btnInstructions.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnInstructions.ForeColor = Color.White;
            btnInstructions.Location = new Point(792, 14);
            btnInstructions.Name = "btnInstructions";
            btnInstructions.Size = new Size(145, 46);
            btnInstructions.TabIndex = 5;
            btnInstructions.Text = "How To Play";
            btnInstructions.UseVisualStyleBackColor = false;
            btnInstructions.Click += btnInstructions_Click;
            // 
            // btnExitGame
            // 
            btnExitGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExitGame.BackColor = Color.Red;
            btnExitGame.FlatStyle = FlatStyle.Popup;
            btnExitGame.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnExitGame.ForeColor = Color.White;
            btnExitGame.Location = new Point(985, 14);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(145, 46);
            btnExitGame.TabIndex = 6;
            btnExitGame.Text = "Exit Game";
            btnExitGame.UseVisualStyleBackColor = false;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1159, 794);
            Controls.Add(btnExitGame);
            Controls.Add(btnInstructions);
            Controls.Add(label1);
            Controls.Add(listBoxHighScores);
            Controls.Add(lblScore);
            Controls.Add(btnStart);
            Controls.Add(pictureBoxGame);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simon";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGame;
        private Button btnStart;
        private Label lblScore;
        private System.Windows.Forms.Timer timerAssign;
        private System.Windows.Forms.Timer timerRead;
        private ListBox listBoxHighScores;
        private Label label1;
        private Button btnInstructions;
        private Button btnExitGame;
        private System.Windows.Forms.Timer timerFlash;
    }
}
