namespace FastFood_Game
{
    public class Game
    {
        public static int LocalScore { get; set; }
        public int LevelNumber { get; set; }
        public int TimeLeftInSec { get; set; }               

        public Game()
        {
            LocalScore = 0;
            LevelNumber = 1;
            TimeLeftInSec = 5; 
        }       
                
        public void AdvanceToNextLevel()
        {
            AddScore();
            IncreaseLevelNumber();            
        }  

        void AddScore()
        {
            LocalScore += 100;
        }

        void IncreaseLevelNumber()
        {
            LevelNumber += 1;
        }               
    }
}
