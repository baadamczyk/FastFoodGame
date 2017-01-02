namespace FastFood_Game
{
    public class GameArea
    {
        public int Height { get; set; }
        public int Width { get; set; }

        const int MaxHeight = 12; //wielokrotności 50ciu (12 = 600)
        const int MaxWidth = 12;

        public GameArea()
        {
            SetGameAreaDimensions(12, 12);
        }

        public void SetGameAreaDimensions(int height, int width)
        {
            if (height > MaxHeight) Height = MaxHeight*50;
            else Height = height*50;

            if (width > MaxWidth) Width = MaxWidth*50;
            else Width = width*50;           
        }
    }
}
