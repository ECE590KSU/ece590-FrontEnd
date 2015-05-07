using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class TextToCube
    {
        /// <summary>
        /// The possible text presentation effects
        /// </summary>
        public enum TEXT_EFFECT { BACK_TO_FRONT, FRONT_TO_BACK, CLOCKWISE_BANNER, COUNTERCLOCKWISE_BANNER, SPIN_3D };

        /// <summary>
        /// The cube controller
        /// </summary>
        private CubeController.Cube _cube;

        /// <summary>
        /// Dictionary to look up effect from string
        /// </summary>
        private Dictionary<string, TEXT_EFFECT> _effectDictionary;

        /// <summary>
        /// The current selected text effect
        /// </summary>
        private TEXT_EFFECT _selectedTextEffect { get; set; }

        /// <summary>
        /// Constructor for the TextToCube Controller
        /// </summary>
        /// <param name="cube">The cube controller</param>
        public TextToCube(ref CubeController.Cube cube)
        {
            _cube = cube;

            _effectDictionary = new Dictionary<string, TEXT_EFFECT>
            {
                {"btnBackToFront", TEXT_EFFECT.BACK_TO_FRONT},
                {"btnFrontToBack", TEXT_EFFECT.FRONT_TO_BACK},
                {"btnClockwiseBanner", TEXT_EFFECT.CLOCKWISE_BANNER}, 
                {"btnCounterclockwiseBanner", TEXT_EFFECT.COUNTERCLOCKWISE_BANNER},
                {"btnSpin3D", TEXT_EFFECT.SPIN_3D}
            };
            
            _selectedTextEffect = TEXT_EFFECT.BACK_TO_FRONT;
        }

        /// <summary>
        /// Changes the selected text effect
        /// </summary>
        /// <param name="p">Name of btn that hold the effect which has changed</param>
        internal void SelectedTextEffectChanged(string p)
        {
            var selectedEffect = _effectDictionary[p];
            _selectedTextEffect = selectedEffect;
        }
        
        /// <summary>
        /// Sends a message to the cube using the selected effect
        /// </summary>
        /// <param name="text">Message to send</param>
        internal void SendMessage(string text)
        {
            switch ( _selectedTextEffect)
            {
                case TEXT_EFFECT.BACK_TO_FRONT: //Need to check if these calls are correct
                    _cube.MessageFlyOnAxis(text, CubeController.Cube.AXIS.AXIS_Y, CubeController.Cube.DIRECTION.REVERSE);
                    break;
                case TEXT_EFFECT.FRONT_TO_BACK: //Need to check if these calls are correct
                    _cube.MessageFlyOnAxis(text, CubeController.Cube.AXIS.AXIS_Y, CubeController.Cube.DIRECTION.FORWARD);
                    break;
                case TEXT_EFFECT.CLOCKWISE_BANNER: //Need to check if these calls are correct
                    _cube.MessageBanner(text, CubeController.Cube.DIRECTION.FORWARD);
                    break;
                case TEXT_EFFECT.COUNTERCLOCKWISE_BANNER: //Need to check if these calls are correct
                    _cube.MessageBanner(text, CubeController.Cube.DIRECTION.REVERSE);
                    break;
                case TEXT_EFFECT.SPIN_3D:
                    break;
                default:
                    break;
            }
        }
    }
}
