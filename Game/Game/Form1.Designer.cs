namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.picturieForPlayer = new System.Windows.Forms.PictureBox();
            this.picturieForPC = new System.Windows.Forms.PictureBox();
            this.winsAndLoses = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnRolls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturieForPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturieForPC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.SlateGray;
            this.btnRock.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRock.Location = new System.Drawing.Point(30, 109);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(85, 29);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Камък";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.SlateGray;
            this.btnPaper.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaper.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPaper.Location = new System.Drawing.Point(30, 254);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(85, 29);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Хартия";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.SlateGray;
            this.btnScissors.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScissors.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScissors.Location = new System.Drawing.Point(30, 178);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(85, 29);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Ножица";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(238, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Игра: Камък, Ножица, Хартия";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRounds.Location = new System.Drawing.Point(401, 264);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(64, 19);
            this.lblRounds.TabIndex = 4;
            this.lblRounds.Text = "Рунд:  1";
            this.lblRounds.Click += new System.EventHandler(this.lblRounds_Click);
            // 
            // picturieForPlayer
            // 
            this.picturieForPlayer.Image = global::WindowsFormsApplication1.Properties.Resources.myQ;
            this.picturieForPlayer.Location = new System.Drawing.Point(155, 109);
            this.picturieForPlayer.Name = "picturieForPlayer";
            this.picturieForPlayer.Size = new System.Drawing.Size(186, 174);
            this.picturieForPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturieForPlayer.TabIndex = 5;
            this.picturieForPlayer.TabStop = false;
            // 
            // picturieForPC
            // 
            this.picturieForPC.Image = global::WindowsFormsApplication1.Properties.Resources.myQ;
            this.picturieForPC.Location = new System.Drawing.Point(531, 109);
            this.picturieForPC.Name = "picturieForPC";
            this.picturieForPC.Size = new System.Drawing.Size(186, 174);
            this.picturieForPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturieForPC.TabIndex = 6;
            this.picturieForPC.TabStop = false;
            // 
            // winsAndLoses
            // 
            this.winsAndLoses.AutoSize = true;
            this.winsAndLoses.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winsAndLoses.Location = new System.Drawing.Point(392, 109);
            this.winsAndLoses.Name = "winsAndLoses";
            this.winsAndLoses.Size = new System.Drawing.Size(86, 19);
            this.winsAndLoses.TabIndex = 7;
            this.winsAndLoses.Text = "Играч: PC:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(461, 188);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(17, 19);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "5";
            // 
            // btnRolls
            // 
            this.btnRolls.BackColor = System.Drawing.Color.SlateGray;
            this.btnRolls.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRolls.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRolls.Location = new System.Drawing.Point(3, 395);
            this.btnRolls.Name = "btnRolls";
            this.btnRolls.Size = new System.Drawing.Size(85, 29);
            this.btnRolls.TabIndex = 10;
            this.btnRolls.Text = "Правила";
            this.btnRolls.UseVisualStyleBackColor = false;
            this.btnRolls.Click += new System.EventHandler(this.btnRolls_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(667, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(399, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Таймер:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(755, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRolls);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.winsAndLoses);
            this.Controls.Add(this.picturieForPC);
            this.Controls.Add(this.picturieForPlayer);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturieForPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturieForPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.PictureBox picturieForPlayer;
        private System.Windows.Forms.PictureBox picturieForPC;
        private System.Windows.Forms.Label winsAndLoses;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnRolls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

