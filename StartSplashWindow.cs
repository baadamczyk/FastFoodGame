using System;
using System.Windows.Forms;

namespace FastFood_Game
{
    public partial class StartSplashWindow : Form
    {        
        public StartSplashWindow()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            Hide();
            MainWindow.Show();
            timer1.Stop();
        }
    }
}
