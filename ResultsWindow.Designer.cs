namespace FastFood_Game
{
    partial class ResultsWindow
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.HiScoresRTextbox = new System.Windows.Forms.RichTextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RetryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MessageLabel.Location = new System.Drawing.Point(12, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(391, 86);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Kot dał drapaka!\r\nOto lista najlepszych wyników:\r\n";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HiScoresRTextbox
            // 
            this.HiScoresRTextbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HiScoresRTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.HiScoresRTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HiScoresRTextbox.Enabled = false;
            this.HiScoresRTextbox.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HiScoresRTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HiScoresRTextbox.Location = new System.Drawing.Point(20, 127);
            this.HiScoresRTextbox.Name = "HiScoresRTextbox";
            this.HiScoresRTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HiScoresRTextbox.ShortcutsEnabled = false;
            this.HiScoresRTextbox.Size = new System.Drawing.Size(371, 295);
            this.HiScoresRTextbox.TabIndex = 1;
            this.HiScoresRTextbox.Text = "";
            this.HiScoresRTextbox.WordWrap = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(65, 482);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Wyjdź z gry";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(245, 482);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(106, 23);
            this.RetryButton.TabIndex = 3;
            this.RetryButton.Text = "Zagraj ponownie";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // ResultsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 536);
            this.ControlBox = false;
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HiScoresRTextbox);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResultsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WYNIKI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.RichTextBox HiScoresRTextbox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RetryButton;
    }
}