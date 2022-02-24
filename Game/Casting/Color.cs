using System.Collections.Generic;



public class Color /// creating the color ints and their values to be used privatly
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;



        public Color (int red, int green, int blue, int alpha){ /// assigning colors with names 
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

        }

        public int GetBlue(){ /// making blue usable
            return blue;

        }

        public int GetGreen(){ /// making green usable
            return green;

        }

        public int GetRed() /// making red usable
{
            return red;

        }

        public int GetAlpha(){ /// making blue usable
            return alpha;

        }


    }