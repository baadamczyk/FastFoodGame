using System;
using System.Drawing;

namespace FastFood_Game
{
    class Cat: IDrawable
    {
        public static int PosX { get; set; }
        public static int PosY { get; set; }  
        public static int Speed { get; set; }
        public static int Direction { get; set; }

        GameArea area = new GameArea();        

        public event EventHandler<CollisionEventArgs> WallCollision;
        public event EventHandler CatCaught;        
                
        public Cat()
        {
            SetCatStaringPositionAndDirection();          
        }

        public void SetCatStaringPositionAndDirection()
        {
            PosX = 300;
            PosY = 150;
            RandomizeDirection(4);
        }           
        
        public void Draw(Graphics graphics)
        {
            Image CatSprite = Image.FromFile(Properties.Settings.Default.CatSpritePath);
            TextureBrush CatBrush = new TextureBrush(CatSprite);
            graphics.FillRectangle(CatBrush, new Rectangle(PosX, PosY, 50, 50));            
        }      

        public void DoRun()
        {
            if (IsCatCaught()) return;
            PreventPositionOverflow();            
            MoveCatSprite();
            HandleCollisions();            
            RandomDirectionChange();           
        }

        void PreventPositionOverflow()
        {
            if(PosX<0)
            {
                Direction = 2;
                PosX = 0;
            }
            else if(PosX>(area.Width-50))
                {
                Direction = 1;
                PosX = area.Width - 50;
            }
            else if(PosY<0)
            {
                Direction = 4;
                PosY = 0;
            }
            else if(PosY>(area.Height-50))
            {
                Direction = 3;
                PosY = area.Height - 50;
            }
        }

        void MoveCatSprite()
        {
            switch (Direction)
            {
                case 1: //lewo
                    PosX -= 50;
                    break;
                case 2: //prawo
                    PosX += 50;
                    break;
                case 3: //góra
                    PosY -= 50;
                    break;
                case 4: //dół
                    PosY += 50;
                    break;
                default:
                    break;
            }
        }

        public void HandleCollisions()                  
        {
            Point CatPosition = new Point(PosX, PosY);
            Point DogPosition = new Point(Dog.PosX, Dog.PosY);

            if (!CollisionOccured()) return;            
        }
        
        bool CollisionOccured()
        {
            if (CatInSWCorner())
            {
                OnWallCollision(5);                
                return true;
            }
            else if (CatInNECorner())
            {
                OnWallCollision(6);               
                return true;
            }
            else if (CatInNWCorner())
            {
                OnWallCollision(7);              
                return true;
            }
            else if (CatInSECorner())
            {
                OnWallCollision(8);                         
                return true;
            }
            else if (PosX == 0)
            {
                OnWallCollision(1);
                return true;
            }
            else if (PosX == (area.Width - 50))
            {
                OnWallCollision(2);
                return true;
            }
            else if (PosY == 0)
            {
                OnWallCollision(3);
                return true;
            }
            else if (PosY == (area.Height - 50))
            {
                OnWallCollision(4);
                return true;
            }
            else return false;
        }

        bool CatInSWCorner()
        {
            if (PosX == 0 && PosY == 0) return true;
            else return false;
        }

        bool CatInNECorner()
        {
            if (PosX == (area.Width - 50) && PosY == 0) return true;
            else return false;
        }

        bool CatInNWCorner()
        {
            if (PosX == 0 && PosY == (area.Height - 50)) return true;
            else return false;
        }

        bool CatInSECorner()
        {
            if (PosX == (area.Width-50) && PosY == (area.Height-50)) return true;
            else return false;
        }

        protected virtual void OnWallCollision(int index)
        {
            WallCollision(this, new CollisionEventArgs() { CollisionIndex = index});
        }
                               
        public bool IsCatCaught()
        {
            Point CatPosition = new Point(PosX, PosY);
            Point DogPosition = new Point(Dog.PosX, Dog.PosY);
            if (CatPosition == DogPosition)
            {
                OnCatCaught();
                return true;
            }
            else return false;
        }

        protected virtual void OnCatCaught()
        {
            CatCaught(this, EventArgs.Empty);
        }


        public static void RandomizeDirection(int CollisionDirectionIndex)
        {
            Random rand = new Random();
            int randomInt = rand.Next(1, 120);
            switch (CollisionDirectionIndex)
            {
                case 1:
                    if (randomInt < 30) Direction =  2;
                    else if (randomInt < 60) Direction =  3;
                    else Direction =  4;
                    break;                 
                case 2:
                    if (randomInt < 30) Direction =  1;
                    else if (randomInt < 60) Direction =  3;
                    else Direction =  4;
                    break;
                case 3:
                    if (randomInt < 30) Direction =  2;
                    else if (randomInt < 60) Direction =  1;
                    else Direction =  4;
                    break;
                case 4:
                    if (randomInt < 30) Direction =  2;
                    else if (randomInt < 60) Direction =  3;
                    else Direction =  1;
                    break;
                case 0:
                    if (randomInt < 30) Direction =  1;
                    else if (randomInt < 60) Direction =  2;
                    else if (randomInt < 80) Direction =  3;
                    else Direction =  4;
                    break;
                default:
                    Direction =  0;
                    break;
            }            
        }
        
        void RandomDirectionChange() 
        {
            Random rand = new Random();
            int Checkpoint = (rand.Next(1,4) * 100);

            if (ReachedWestCheckpoint(Checkpoint)) Direction = 2;            
            else if (ReachedEastCheckpoint(Checkpoint)) Direction = 1;        
            else if (ReachedNorthCheckpoint(Checkpoint)) Direction = 4;
            else if (ReachedSouthCheckpoint(Checkpoint)) Direction = 3;
            else return;
        }
        
        bool ReachedWestCheckpoint(int checkpointposition)
        {
            if (PosX == 0 && (PosY == checkpointposition)) return true;
            else return false;
        }    

        bool ReachedEastCheckpoint(int checkpointposition)
        {
            if (PosX == area.Width - 50 && (PosY == checkpointposition)) return true;
            else return false;
        }

        bool ReachedNorthCheckpoint(int checkpointposition)
        {
            if (PosY == 0 && (PosX == checkpointposition)) return true;
            else return false;
        }

        bool ReachedSouthCheckpoint(int checkpointposition)
        {
            if (PosY == area.Height - 50 && (PosX == checkpointposition)) return true;
            else return false;
        }
    }
}
