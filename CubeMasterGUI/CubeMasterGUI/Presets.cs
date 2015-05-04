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

        public Presets(ref CubeController.Cube cube)
        {
            _cube = cube;
            _presets = new List<System.Windows.Forms.Button>();
            PopulateButtonList();
            PopulateDictionary();
        }

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

        public void UpdateDelay(int delay)
        {
            _delay = delay;
        }

        private void PopulateButtonList()
        {
            NewButton("btnFirework", "Firework");
            NewButton("btnRain", "Rain");
            NewButton("btnSmiley", "Smiley");   
            NewButton("btnStairs", "Stairs");   
            NewButton("btnBoing", "Boing");    
            NewButton("btnBoxWoop", "Box Woop-Woop");  
            NewButton("btnRandSusp", "Random Suspend"); 
            NewButton("btnSparkle", "Sparkle"); 
            NewButton("btnScramble", "Scramble"); 
            NewButton("btnLoadBar", "LoadBar");
            NewButton("btnVxlTest", "Voxel Test"); 
            NewButton("btnVrtSpiral", "Vertical Spiral");
            NewButton("btnLineSpin", "LineSpin"); 
            NewButton("btnSideWaves", "Side Waves");
            NewButton("btnSineWaves", "Sine Waves");
            NewButton("btnRipple", "Ripple");
        }

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

        private System.Windows.Forms.Button NewButton(string name, string text)
        {
            var button = new System.Windows.Forms.Button();
            button.Name = name;
            button.Text = text;
            button.Size = new System.Drawing.Size(50, 50);
            button.ForeColor = System.Drawing.Color.SteelBlue;
            button.BackColor = System.Drawing.Color.GhostWhite;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Click += ButtonClickEventHandler;
            return button;
        }
    }
}
