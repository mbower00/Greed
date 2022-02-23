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

        public void GetNextPosition()
        {

        }


    }
}
