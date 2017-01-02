namespace FastFood_Game
{
    partial class StartSplashWindow
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
            this.StartPicturebox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StartPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPicturebox
            // 
            this.StartPicturebox.Image = global::FastFood_Game.Properties.Resources.game_title_image;
            this.StartPicturebox.Location = new System.Drawing.Point(-1, 0);
            this.StartPicturebox.Name = "StartPicturebox";
            this.StartPicturebox.Size = new System.Drawing.Size(281, 165);
            this.StartPicturebox.TabIndex = 0;
            this.StartPicturebox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartSplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.StartPicturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartSplashWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartSplashWindow";
            ((System.ComponentModel.ISupportInitialize)(this.StartPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPicturebox;
        private System.Windows.Forms.Timer timer1;
    }
}