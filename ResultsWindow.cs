using System;
using System.Windows.Forms;

namespace FastFood_Game
{
    public partial class ResultsWindow : Form
    {

        public ResultsWindow()
        {
            InitializeComponent();
            DisplayScoresOnForm();
            CheckForNewHighscore();            
        }

        HiScores Scores = new HiScores();

        void DisplayScoresOnForm()
        {
            foreach(HiScoreRecord record in HiScores.HiScoreList)
            {
                WriteRecordLineToTextbox(record);
            }
        }

        void WriteRecordLineToTextbox(HiScoreRecord record)
        {
            HiScoresRTextbox.Text += BuildStringFromRecordData(record);
        }

        string BuildStringFromRecordData(HiScoreRecord record)
        {
            return GetItemIndex(record) + " " + record.PlayerName + " " + record.ReachedScore.ToString() + " punktów\n\n";
        }

        string GetItemIndex(HiScoreRecord record)
        {
            return (HiScores.HiScoreList.IndexOf(record)+1).ToString();
        }


        void CheckForNewHighscore()
        {
            bool IsNewHighscore = false;            
            foreach (HiScoreRecord record in HiScores.HiScoreList)
            {
                if (Game.LocalScore > record.ReachedScore) IsNewHighscore = true;          
            }
            if (IsNewHighscore)
            {
                ShowRegisterScoreDialog();
                Hide();
            }
        }       

        void ShowRegisterScoreDialog()
        {
            RegisterNewHighscoreDialog Dialog = new RegisterNewHighscoreDialog();
            Dialog.Show();      
                  
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void RetryButton_Click(object sender, EventArgs e)
        {
            StartNewRound();              
        }

        void StartNewRound()
        {
            MainWindow MainWindow = new MainWindow();
            Hide();
            MainWindow.Show();
        }
    }
}
