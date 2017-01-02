namespace FastFood_Game
{
    partial class WinSplashWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.SplashPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "KOTEK PRZYTULONY!";
            // 
            // SplashPicturebox
            // 
            this.SplashPicturebox.Image = global::FastFood_Game.Properties.Resources.win_graphics;
            this.SplashPicturebox.ImageLocation = "";
            this.SplashPicturebox.Location = new System.Drawing.Point(-2, -2);
            this.SplashPicturebox.Name = "SplashPicturebox";
            this.SplashPicturebox.Size = new System.Drawing.Size(563, 457);
            this.SplashPicturebox.TabIndex = 0;
            this.SplashPicturebox.TabStop = false;
            // 
            // WinSplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SplashPicturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinSplashWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSplash";
            ((System.ComponentModel.ISupportInitialize)(this.SplashPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashPicturebox;
        private System.Windows.Forms.Label label1;
    }
}