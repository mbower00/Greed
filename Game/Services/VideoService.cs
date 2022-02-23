/*
using System.Collections.Generic;
using Raylib_cs;
using cse210_greed.Game.Casting;
// dotnet restore

namespace cse210_greed.Game.Services
{
    /// <summary>
    /// Top Text - Bottom Text
    /// </summary>
    public class VideoService
    {
        private int cellSize = 15;
        private string score = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        

        /// <summary>
        ///
        /// </summary>
        public VideoService()
        {

        }

        /// <summary>
        /// Terminates code when window is closed.
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        ///
        ///
        ///
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
        }

        ///
        ///
        ///
        public void DrawActor(Actor actor)
        {
            int x = actor.GetPosistion().GetX();
            int y = actor.GetPosistion().GetY();
            int fontSize = actor.GetFontSize();
            // Casting.Color c = ToRaylibColor(c);

        }
    }
}
*/
