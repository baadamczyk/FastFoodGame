namespace FastFood_Game
{
    public class Collisions
    {   
        public static int CollisionIndex { get; set; }

        public void OnWallCollision(object sender, CollisionEventArgs e)
        {
            SetCollisionIndexToEventParam(e);
            if (CollisionIndex == 5) Cat.Direction = 4;
            else if (CollisionIndex == 6) Cat.Direction = 4;
            else if (CollisionIndex == 7) Cat.Direction = 2;
            else if (CollisionIndex == 8) Cat.Direction = 1;
            else Cat.RandomizeDirection(CollisionIndex);                       
        }
        void SetCollisionIndexToEventParam( CollisionEventArgs e)
        {
            CollisionIndex = e.CollisionIndex;
        }
    }
}
