using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace FastFood_Game
{
    public class HiScores
    {
        public static string NewName;
        static bool FileRetrieved = false;
        public static List<HiScoreRecord> HiScoreList = new List<HiScoreRecord>();

        public HiScores()
        {
            if(!FileRetrieved) RetrieveListFromFile();            
        }

        void RetrieveListFromFile()
        {           
            var RawRecords = File.ReadAllLines(Properties.Settings.Default.HiScoreListPath);
            foreach (string record in RawRecords)
            {
                ProcessRecord(record);
            }
            FileRetrieved = true;
        }
            
        void ProcessRecord(string record)
        {
            if (record == "") return;
            else
            {
                string Name = record.Substring(0, 5);
                int Score = int.Parse(record.Substring(5, record.Length - 5));
                HiScoreList.Add(new HiScoreRecord() { PlayerName = Name, ReachedScore = Score });
            }
        }            
       

        public void UpdateScoreboard()
        {
            AddNewRecord();
            SortRecordsByPoints();
            RemoveExceedRecord();
            ResetLocalScore();
            SaveScoreboardToFile();
            ResultsWindow results = new ResultsWindow();
            results.Show();                                                
        }

        void AddNewRecord()
        {
            HiScoreList.Add(new HiScoreRecord() { PlayerName = NewName, ReachedScore = Game.LocalScore });
        }

        void SortRecordsByPoints()                             
        {
            HiScoreList = HiScoreList.OrderByDescending(score => score.ReachedScore).ToList();            
        }

        void RemoveExceedRecord()
        {
            HiScoreList.RemoveAt(5); 
        }       

        void ResetLocalScore()
        {
            Game.LocalScore = 0;
        }

        void SaveScoreboardToFile()
        {
            using (StreamWriter FileWriter = new StreamWriter(Properties.Settings.Default.HiScoreListPath, false))
            {
                foreach (HiScoreRecord record in HiScoreList)
                {
                    FileWriter.WriteLine(record.PlayerName + record.ReachedScore.ToString());
                }                
            }
        }        
    }
}
