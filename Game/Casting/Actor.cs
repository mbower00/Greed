using System;

namespace cse210_greed.Game.Casting
{
    public class Actor
    {
        private string text = " ";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255, 255);
        private Location position = new Location(0, 0);
        private Location velocity = new Location(0, 0);

        public Actor()
        {

        }

        public Color GetColor()
        {
            return color;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public Location GetPosition()
        {
            return position;
        }

        public string GetText()
        {
            return text;
        }

        public Location GetVelocity()
        {
            return velocity;
        }

        public void GetNextPosition(int maxX, int maxY)
        {
            int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            position = new Location(x, y);
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetPosition(Location position)
        {
            this.position = position;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetVelocity(Location velocity)
        {
            this.velocity = velocity;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }


    }
}
