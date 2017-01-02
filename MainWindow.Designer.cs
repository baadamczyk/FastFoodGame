namespace FastFood_Game
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GameArea = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LevelGroupbox = new System.Windows.Forms.GroupBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ScoreGroupbox = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeGroupbox = new System.Windows.Forms.GroupBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.LevelGroupbox.SuspendLayout();
            this.ScoreGroupbox.SuspendLayout();
            this.TimeGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameArea.Location = new System.Drawing.Point(3, 12);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(600, 600);
            this.GameArea.TabIndex = 0;
            this.GameArea.TabStop = false;
            this.GameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GameArea_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LevelGroupbox
            // 
            this.LevelGroupbox.Controls.Add(this.LevelLabel);
            this.LevelGroupbox.Location = new System.Drawing.Point(630, 146);
            this.LevelGroupbox.Name = "LevelGroupbox";
            this.LevelGroupbox.Size = new System.Drawing.Size(120, 38);
            this.LevelGroupbox.TabIndex = 1;
            this.LevelGroupbox.TabStop = false;
            this.LevelGroupbox.Text = "Poziom";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelLabel.Location = new System.Drawing.Point(24, 16);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(70, 13);
            this.LevelLabel.TabIndex = 0;
            this.LevelLabel.Text = "LEVEL_NR";
            // 
            // ScoreGroupbox
            // 
            this.ScoreGroupbox.Controls.Add(this.ScoreLabel);
            this.ScoreGroupbox.Location = new System.Drawing.Point(630, 190);
            this.ScoreGroupbox.Name = "ScoreGroupbox";
            this.ScoreGroupbox.Size = new System.Drawing.Size(120, 38);
            this.ScoreGroupbox.TabIndex = 2;
            this.ScoreGroupbox.TabStop = false;
            this.ScoreGroupbox.Text = "Punkty";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(24, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(49, 13);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "SCORE";
            // 
            // TimeGroupbox
            // 
            this.TimeGroupbox.Controls.Add(this.TimeLabel);
            this.TimeGroupbox.Location = new System.Drawing.Point(630, 234);
            this.TimeGroupbox.Name = "TimeGroupbox";
            this.TimeGroupbox.Size = new System.Drawing.Size(120, 38);
            this.TimeGroupbox.TabIndex = 2;
            this.TimeGroupbox.TabStop = false;
            this.TimeGroupbox.Text = "Pozostały czas";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLabel.Location = new System.Drawing.Point(24, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(74, 13);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "TIME_LEFT";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 615);
            this.Controls.Add(this.ScoreGroupbox);
            this.Controls.Add(this.TimeGroupbox);
            this.Controls.Add(this.LevelGroupbox);
            this.Controls.Add(this.GameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastFood";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.LevelGroupbox.ResumeLayout(false);
            this.LevelGroupbox.PerformLayout();
            this.ScoreGroupbox.ResumeLayout(false);
            this.ScoreGroupbox.PerformLayout();
            this.TimeGroupbox.ResumeLayout(false);
            this.TimeGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.PictureBox GameArea;
        private System.Windows.Forms.GroupBox LevelGroupbox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.GroupBox ScoreGroupbox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.GroupBox TimeGroupbox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

