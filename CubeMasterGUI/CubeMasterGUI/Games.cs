using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class Games
    {
        /// <summary>
        /// Cube controller
        /// </summary>
        private CubeController.Cube _cube;

        /// <summary>
        /// Constructor for a new Games controller
        /// </summary>
        /// <param name="cube">Cube controller</param>
        public Games(ref CubeController.Cube cube)
        {
            _cube = cube;
        }

        /// <summary>
        /// Launches a new snake game
        /// </summary>
        /// <param name="width">Parent form width</param>
        /// <param name="height">Parent form height</param>
        public void LaunchSnake(int width, int height)
        {
            frmSnake snake = new frmSnake(ref _cube, width, height);

            if (snake.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// Launches a new catcher game
        /// </summary>
        /// <param name="width">Parent form width</param>
        /// <param name="height">Parent form height</param>
        public void LaunchCatcher(int width, int height)
        {
            frmCatcher catcher = new frmCatcher(ref _cube, width, height);

            if (catcher.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }

    /// <summary>
    /// Class representing a high score
    /// </summary>
    internal class HighScore
    {
        /// <summary>
        /// The users name (3 letter initials)
        /// </summary>
        public string Name;

        /// <summary>
        /// The users score
        /// </summary>
        public int Score;

        /// <summary>
        /// The difficulty setting at which it was achieved
        /// </summary>
        public string Difficulty;

        /// <summary>
        /// Constructor for a new high score
        /// </summary>
        /// <param name="name">Users name</param>
        /// <param name="score">Users score</param>
        /// <param name="difficulty">Difficulty setting</param>
        public HighScore(string name, int score, string difficulty)
        {
            Name = name;
            Score = score;
            Difficulty = difficulty;
        }

        /// <summary>
        /// Overrides the ToString method to produce a formatted string representing this class
        /// </summary>
        /// <returns>Name: score (Difficulty)</returns>
        public override string ToString()
        {
            return Name + ": " + Score.ToString() + " (" + Difficulty + ")";
        }
    }
}
