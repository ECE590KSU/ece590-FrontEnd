using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class Presets
    {
        private CubeController.Cube _cube;
        private int _delay;
        private List<System.Windows.Forms.Button> _presets;
        private Dictionary<string, PRESETS> _presetsDictionary;

        private enum PRESETS { FIREWORK, RAIN, SMILEY_SPIN, TELC_STAIRS, AXIS_BOING,
                               BOX_WOOP, AXIS_RAND_SUSP, RAND_SPARKLE, SCRAMBLE,
                               LOAD_BAR, VOXEL_TEST, VERT_SPIRAL, LINE_SPIN, SIDE_WAVES,
                               SINE_WAVES, RIPPLE };

        /// <summary>
        /// Constructor for presets
        /// </summary>
        /// <param name="cube"></param>
        public Presets(ref CubeController.Cube cube)
        {
            _cube = cube;
            _presets = new List<System.Windows.Forms.Button>();
            PopulateButtonList();
            PopulateDictionary();
        }

        /// <summary>
        /// Updates the delay variable
        /// </summary>
        /// <param name="delay">New delay</param>
        public void UpdateDelay(int delay)
        {
            _delay = delay;
        }

        /// <summary>
        /// Gets the list of buttons
        /// </summary>
        /// <returns>List of the button controls</returns>
        public List<System.Windows.Forms.Button> GetButtonList()
        {
            return _presets;
        } 

        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickEventHandler(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            var effect = _presetsDictionary[button.Name];
            switch (effect)
            {
                case PRESETS.FIREWORK:
                    break;
                case PRESETS.RAIN:
                    break;
                case PRESETS.SMILEY_SPIN:
                    break;
                case PRESETS.TELC_STAIRS:
                    break;
                case PRESETS.AXIS_BOING:
                    break;
                case PRESETS.BOX_WOOP:
                    break;
                case PRESETS.AXIS_RAND_SUSP:
                    break;
                case PRESETS.RAND_SPARKLE:
                    break;
                case PRESETS.SCRAMBLE:
                    break;
                case PRESETS.LOAD_BAR:
                    break;
                case PRESETS.VOXEL_TEST:
                    break;
                case PRESETS.VERT_SPIRAL:
                    break;
                case PRESETS.LINE_SPIN:
                    break;
                case PRESETS.SIDE_WAVES:
                    break;
                case PRESETS.SINE_WAVES:
                    break;
                case PRESETS.RIPPLE:
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// Populates the button list
        /// </summary>
        private void PopulateButtonList()
        {
            _presets.Add(NewButton("btnFirework", "Firework"));
            _presets.Add(NewButton("btnRain", "Rain"));
            _presets.Add(NewButton("btnSmiley", "Smiley"));   
            _presets.Add(NewButton("btnStairs", "Stairs"));   
            _presets.Add(NewButton("btnBoing", "Boing"));    
            _presets.Add(NewButton("btnBoxWoop", "Box Woop-Woop"));  
            _presets.Add(NewButton("btnRandSusp", "Random Suspend")); 
            _presets.Add(NewButton("btnSparkle", "Sparkle")); 
            _presets.Add(NewButton("btnScramble", "Scramble")); 
            _presets.Add(NewButton("btnLoadBar", "LoadBar"));
            _presets.Add(NewButton("btnVxlTest", "Voxel Test")); 
            _presets.Add(NewButton("btnVrtSpiral", "Vertical Spiral"));
            _presets.Add(NewButton("btnLineSpin", "LineSpin")); 
            _presets.Add(NewButton("btnSideWaves", "Side Waves"));
            _presets.Add(NewButton("btnSineWaves", "Sine Waves"));
            _presets.Add(NewButton("btnRipple", "Ripple"));
        }

        /// <summary>
        /// Populates the lookup dictionary
        /// </summary>
        private void PopulateDictionary()
        {
            _presetsDictionary = new Dictionary<string, PRESETS>
            {
                {"btnFirework", PRESETS.FIREWORK},
                {"btnRain",     PRESETS.RAIN},
                {"btnSmiley",   PRESETS.SMILEY_SPIN},
                {"btnStairs",   PRESETS.TELC_STAIRS},
                {"btnBoing",    PRESETS.AXIS_BOING},
                {"btnBoxWoop",  PRESETS.BOX_WOOP},
                {"btnRandSusp", PRESETS.AXIS_RAND_SUSP},
                {"btnSparkle",  PRESETS.RAND_SPARKLE},
                {"btnScramble", PRESETS.SCRAMBLE},
                {"btnLoadBar",  PRESETS.LOAD_BAR},
                {"btnVxlTest",  PRESETS.VOXEL_TEST},
                {"btnVrtSpiral",PRESETS.VERT_SPIRAL},
                {"btnLineSpin", PRESETS.LINE_SPIN},
                {"btnSideWaves",PRESETS.SIDE_WAVES},
                {"btnSineWaves",PRESETS.SINE_WAVES},
                {"btnRipple",   PRESETS.RIPPLE}
            };
        }

        /// <summary>
        /// Creates a new button of a specific style
        /// </summary>
        /// <param name="name">The button's name</param>
        /// <param name="text">The button's text</param>
        /// <returns></returns>
        private System.Windows.Forms.Button NewButton(string name, string text)
        {
            var button = new System.Windows.Forms.Button();
            button.Name = name;
            button.Text = text;
            button.Size = new System.Drawing.Size(200, 200);
            button.ForeColor = System.Drawing.Color.SteelBlue;
            button.BackColor = System.Drawing.Color.GhostWhite;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("SegoeUI", 14);
            button.Click += ButtonClickEventHandler;
            return button;
        }
    }
}
