using System;
using System.Windows.Forms;

namespace FastFood_Game
{
    public partial class RegisterNewHighscoreDialog : Form
    {
        public RegisterNewHighscoreDialog()
        {
            InitializeComponent();
            NameInputTextbox.Clear();
            Focus();
        }

        private void NameInputTextbox_Leave(object sender, EventArgs e)
        {
            
        }

        bool VerifyNameLenght()
        {
            if (!IsNameLenghtValid())
            {
                ShowMessageAndClearInput();
                return false;
            }
            else return true;
        }

        bool IsNameLenghtValid()
        {
            if (NameInputTextbox.Text == "") return false;
            else if (NameInputTextbox.TextLength > 5) return false;
            else if (NameInputTextbox.TextLength<5)
            {
                FillInBlanks();
                return true;
            }
            else return true;
        }

        void FillInBlanks()
        {
            for(int i=0; i<=(5-NameInputTextbox.TextLength);i++)
            {
                NameInputTextbox.Text += " ";
            }
        }

        void ShowMessageAndClearInput()
        {
            MessageBox.Show("Twoja nazwa może zawierać maksymalnie 5 znaków!");
            NameInputTextbox.Clear();
            NameInputTextbox.Focus();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(VerifyNameLenght()) AssignNewNameData();    
        }

        void AssignNewNameData()
        {
            HiScores scores = new HiScores();
            HiScores.NewName = NameInputTextbox.Text.ToString();
            scores.UpdateScoreboard();            
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
