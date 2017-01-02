namespace FastFood_Game
{
    partial class RegisterNewHighscoreDialog
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
            this.NameInputTextbox = new System.Windows.Forms.TextBox();
            this.NameAcceptButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź swoje imię:\r\n";
            // 
            // NameInputTextbox
            // 
            this.NameInputTextbox.Location = new System.Drawing.Point(37, 49);
            this.NameInputTextbox.Name = "NameInputTextbox";
            this.NameInputTextbox.Size = new System.Drawing.Size(163, 20);
            this.NameInputTextbox.TabIndex = 1;
            this.NameInputTextbox.Leave += new System.EventHandler(this.NameInputTextbox_Leave);
            // 
            // NameAcceptButton
            // 
            this.NameAcceptButton.Location = new System.Drawing.Point(147, 93);
            this.NameAcceptButton.Name = "NameAcceptButton";
            this.NameAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.NameAcceptButton.TabIndex = 2;
            this.NameAcceptButton.Text = "Zapisz";
            this.NameAcceptButton.UseVisualStyleBackColor = true;
            this.NameAcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DiscardButton
            // 
            this.DiscardButton.Location = new System.Drawing.Point(13, 93);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(75, 23);
            this.DiscardButton.TabIndex = 3;
            this.DiscardButton.Text = "Anuluj";
            this.DiscardButton.UseVisualStyleBackColor = true;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // RegisterNewHighscoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 141);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.NameAcceptButton);
            this.Controls.Add(this.NameInputTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterNewHighscoreDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOWY REKORD!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInputTextbox;
        private System.Windows.Forms.Button NameAcceptButton;
        private System.Windows.Forms.Button DiscardButton;
    }
}