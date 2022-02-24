using System.Collections.Generic;


namespace cse210_greed.Game.Casting
{
    public class Color
        {
            private int red = 0;
            private int green = 0;
            private int blue = 0;
            private int alpha = 255;



            public Color (int red, int green, int blue, int alpha){
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.alpha = alpha;

            }

            public int GetBlue(){
                return blue;

            }

            public int GetGreen(){
                return green;

            }

            public int GetRed()
    {
                return red;

            }

            public int GetAlpha(){
                return alpha;

            }

        }
}