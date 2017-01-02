using System;
using System.Drawing;
using System.Windows.Forms;

namespace FastFood_Game
{
    public partial class MainWindow : Form
    {
        WinSplashWindow WinSplash = new WinSplashWindow();
        Game NewGame = new Game();
        Dog Spanielek = new Dog();
        Cat Kocislaw = new Cat();
        GameArea FirstField = new GameArea();
        Collisions collisions = new Collisions();
             
        
        public MainWindow()
        {
            InitializeComponent();
            InitializeGameSettings();              
        }

        void InitializeGameSettings()
        {
            AssociateGameAreaDimensions();            
            RegisterActionsToEvents();
            AssignValuesToInfoFields();
            SetTimers();
        }

        void AssociateGameAreaDimensions()
        {
            GameArea.Height = FirstField.Height;
            GameArea.Width = FirstField.Width;
        }

        void SetTimers()
        {
            SetTimer(timer1, 50);
            SetTimer(timer2, 1000);
            SetTimer(timer3, 1000);
        }

        void SetTimer(Timer timer, int interval)
        {
            timer.Interval = interval;
            timer.Start();
        }

        void RegisterActionsToEvents()
        {
            Kocislaw.WallCollision += collisions.OnWallCollision;
            Kocislaw.CatCaught += OnCatCaught;
        }
        
        void AssignValuesToInfoFields()
        {
            LevelLabel.Text = NewGame.LevelNumber.ToString();
            ScoreLabel.Text = Game.LocalScore.ToString();
            TimeLabel.Text = NewGame.TimeLeftInSec.ToString();
        }              

        private void GameArea_Paint(object sender, PaintEventArgs e)
        {
            DrawSprites(e);
        }

        void DrawSprites(PaintEventArgs e)
        {
            Graphics GameGraphics = e.Graphics;
            Spanielek.Draw(GameGraphics);
            Kocislaw.Draw(GameGraphics);
        }        

        public void OnCatCaught(object sender,EventArgs args)
        {
            StopTimers();
            NewGame.AdvanceToNextLevel();
            AssignValuesToInfoFields();
            RestartGame();                          
        }

        void RestartGame()
        {            
            ReSetSpritesStartingPositions();
            IncreaseCatSpeed();
            ResetGameTimer();
            SplashWinImage();         
        }

        public void RestartGame(bool retry)
        {
            ReSetSpritesStartingPositions();
            ReturnToFirstLevelState();
            ResetGameTimer();            
        }

        void ReturnToFirstLevelState()
        {
            timer2.Interval = 1000;
            NewGame.LevelNumber = 1;
            Game.LocalScore = 0;
        }

        void ReSetSpritesStartingPositions()
        {
            Kocislaw.SetCatStaringPositionAndDirection();
            Spanielek.SetDogStartingPosition();            
        }

        void IncreaseCatSpeed()
        { 
            SetCatTimerInterval();                  
        }

        void SetCatTimerInterval()
        {
            timer2.Interval = ((timer2.Interval / 6) * 2);
            if (timer2.Interval < 20) timer2.Interval = 20;
        }

        void ResetGameTimer()
        {
            if (NewGame.LevelNumber > 5) NewGame.TimeLeftInSec = 3;
            else NewGame.TimeLeftInSec = 5;
            TimeLabel.Text = NewGame.TimeLeftInSec.ToString();
        }

        void SplashWinImage()
        {            
            WinSplash.Show();
            WaitForImageToSplash();       
        }

        void WaitForImageToSplash()
        {
            timer4.Interval = 2000;
            timer4.Start();
        }

        void StopTimers()
        {
            timer3.Stop();
            timer2.Stop();
            timer1.Stop();
        }
               

        void StartTimers()
        {
            timer3.Start();
            timer2.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameArea.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Kocislaw.DoRun();
            GameArea.Invalidate();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            GameArea.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) Spanielek.Move(3);
            else if (e.KeyCode == Keys.Down) Spanielek.Move(4);
            else if (e.KeyCode == Keys.Left) Spanielek.Move(1);
            else if (e.KeyCode == Keys.Right) Spanielek.Move(2);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            WinSplash.Hide();
            StartTimers();
            timer4.Stop();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (NewGame.TimeLeftInSec != 0) DecrementTimeValue();
            else SumUpTheGame();
        }

        void DecrementTimeValue()
        {
            NewGame.TimeLeftInSec--;
            TimeLabel.Text = NewGame.TimeLeftInSec.ToString();
        }

        void SumUpTheGame()
        {
            StopTimers();
            ShowResultsWindow();           
        }

        void ShowResultsWindow()
        {
            ResultsWindow Result = new ResultsWindow();
            Result.Show();
            Close();
        }
    }
}
