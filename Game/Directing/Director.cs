using System;
using System.Collections.Generic;
using cse210_greed.Game.Casting;
using cse210_greed.Game.Services;

namespace cse210_greed.Game.Directing{
    /// <summary>
    /// The person who directs the game.
    /// Responsibility: Control the steps of the game.
    /// </summary>
    public class Director{
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;
        private int playerScore = 0;
        Random random = new Random();
        int COLS;
        int ROWS;
        int CELL_SIZE;


        /// <summary>
        /// Constructs an instance of director
        /// </summary>
        /// <param name="keyboardService">The passed instance of KeyboardService</param>
        /// <param name="videoService">The passed instance of VideoService</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
            CELL_SIZE = videoService.GetCellSize();
            COLS = videoService.GetWidth() / CELL_SIZE;
            ROWS = videoService.GetHeight() / CELL_SIZE;
        }

        /// <summary>
        /// Starts the game loop for the passed cast
        /// </summary>
        /// <param name="cast">The passed instance 
        /// of cast (should already be populated
        /// with the proper actors)</param>
        public void StartGame(Cast cast){
            videoService.OpenWindow();
            while (videoService.IsWindowOpen()){
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard 
        /// and applies the directional  to the robot
        /// </summary>
        /// <param name="cast">The passed instance of cast</param>
        private void GetInputs(Cast cast){
            Actor robot = cast.GetFirstActor("robot");
            Location velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);
        }

        /// <summary>
        /// Updates the robot and falling artifact positions 
        /// and resolves collisions 
        /// (i.e robot to artifact(s))
        /// </summary>
        /// <param name="cast">The passed instance of cast</param>
        private void DoUpdates(Cast cast){
            //declarations
            List<Actor> banners = cast.GetActors("banner"); 
                //index [0]: scoreBanner
                Actor scoreBanner = banners[0];
                //index [1]: dialogueBanner
                Actor dialogueBanner = banners[1];
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();

            foreach (Actor actor in artifacts){
                Artifact artifact = (Artifact) actor; //look into
                bool isCaughtRecently = false;
                
                if (robot.GetPosition().Equals(artifact.GetPosition())){
                    //set dialogue to the artifact's message.
                    dialogueBanner.SetText(artifact.GetMessage());
                    
                    //score increase/decrease
                    playerScore += artifact.GetPointValue();
                    
                    //move artifact to just above the top
                    Location position = new Location(random.Next(1, COLS), 1);
                    position = position.Scale(CELL_SIZE);
                    artifact.SetPosition(position);
                    isCaughtRecently = true;
                }
                
                if(!isCaughtRecently){
                    //the fall speed indicates the chance for delay in falling
                    if(random.Next(0, artifact.GetFallSpeed() + 1) == 0){
                        //move the artifact down
                        artifact.SetVelocity(keyboardService.GetDirection("down"));
                        artifact.GetNextPosition(maxX, maxY);
                    }
                        
                    isCaughtRecently = false;
                }
            }
            
            //update player's score to the score banner
            scoreBanner.SetText($"Score: {playerScore}");
            //move robot
            robot.GetNextPosition(maxX, maxY);
        }

        /// <summary>
        /// Draws the actors on the display screen
        /// </summary>
        /// <param name="cast">The passed instance of cast</param>
        private void DoOutputs(Cast cast){
            //declare actors to be drawn
            List<Actor> actors = cast.GetAllActors();
            
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }
    }
}