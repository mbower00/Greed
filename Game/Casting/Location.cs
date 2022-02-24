namespace cse210_greed.Game.Casting
{
    public class Location
    {
        private int x = 0;
        private int y = 0;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Location Add(Location other)
        {
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();
            return new Location(x, y);
        }

        public bool Equals(Location other)
        {
            return this.x == other.GetX() && this.y == other.GetY();
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public Location Scale(int factor)
        {
            int x = this.x * factor;
            int y = this.y * factor;
            return new Location(x, y);
        }


    }
    
    
}