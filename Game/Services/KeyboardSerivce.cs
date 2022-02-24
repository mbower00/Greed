using Raylib_cs;
using cse210_greed.Game.Casting;
// dotnet restore

namespace cse210_greed.Game.Services
{
    /// <summary>
    /// Allows use of keyboard.
    /// </summary>
    public class KeyboardService
    {
        private int cellSize = 15;

        /// <summary>
        /// Constructor  --  Sets how far each arrow will move.
        /// </summary>
        public KeyboardService(int cellSize)
        {
            this.cellSize = cellSize;
        }

        /// <summary>
        /// Converts keyboard presses into movement.
        /// </summary>
        public Location GetDirection()
        {
            int dx = 0;
            int dy = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }

            Location direction = new Location(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }
    }
}