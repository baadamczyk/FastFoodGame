using System.Drawing;

namespace FastFood_Game
{
    public class Dog: IDrawable
    {        
        public static int PosX { get; set; }
        public static int PosY { get; set; }

        public Dog()
        {
            SetDogStartingPosition();
        }

        public void SetDogStartingPosition()
        {
            PosX = 250;
            PosY = 550;
        }

        public void Draw(Graphics graphics)
        {
            Image DogSprite = Image.FromFile(Properties.Settings.Default.DogSpritePath);
            TextureBrush DogBrush = new TextureBrush(DogSprite);
            graphics.FillRectangle(DogBrush, new Rectangle(PosX, PosY, 50, 50));
        }                     

        public void Move(int direction)
        {            
            switch (direction)
                {                                
                    case 1:
                        if(IsOnWestBorder()) PosX -= 50;
                        break;
                    case 2: 
                        if(IsOnEastBorder()) PosX += 50;
                        break;
                    case 3: 
                        if(IsOnNorthBorder()) PosY -= 50;
                        break;
                    case 4:
                        if(IsOnSouthBorder()) PosY += 50;
                        break;
                    default:
                        break;
                }                     
        }           
        
        bool IsOnWestBorder()
        {
            if (IsOnBorder() != 2 && IsOnBorder() != 3 && IsOnBorder() != 5) return true;
            else return false;
        }

        bool IsOnEastBorder()
        {
            if (IsOnBorder() != 1 && IsOnBorder() != 4 && IsOnBorder() != 6) return true;
            else return false;
        }

        bool IsOnNorthBorder()
        {
            if (IsOnBorder() != 1 && IsOnBorder() != 2 && IsOnBorder() != 7) return true;
            else return false;
        }

        bool IsOnSouthBorder()
        {
            if (IsOnBorder() != 3 && IsOnBorder() != 4 && IsOnBorder() != 8) return true;
            else return false;
        }
        
        int IsOnBorder()
        {
            GameArea area = new GameArea();
            Point DogPosition = new Point(PosX, PosY);
            Point NWCorner = new Point(0, 0);
            Point NECorner = new Point(area.Width-50,0);
            Point SECorner = new Point(area.Width - 50, area.Height - 50);
            Point SWCorner = new Point(0, area.Height - 50);

            if (DogPosition == NECorner) return 1;
            else if (DogPosition == NWCorner) return 2;
            else if (DogPosition == SWCorner) return 3;
            else if (DogPosition == SECorner) return 4;
            else if (PosX == 0) return 5;
            else if (PosX == (area.Width-50)) return 6;
            else if (PosY == 0) return 7;
            else if (PosY == (area.Height-50)) return 8;
            else return 0;           
        }                      
    }
}
