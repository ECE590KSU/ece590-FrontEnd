using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeMasterGUI
{
    public class TextToCube
    {
        public enum TEXT_EFFECT { BACK_TO_FRONT, FRONT_TO_BACK, CLOCKWISE_BANNER, COUNTERCLOCKWISE_BANNER, SPIN_3D };

        private CubeController.Cube _cube;

        private Dictionary<string, TEXT_EFFECT> _effectDictionary;

        private TEXT_EFFECT _selectedTextEffect { get; set; }

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

        internal void SelectedTextEffectChanged(string p)
        {
            var selectedEffect = _effectDictionary[p];
            _selectedTextEffect = selectedEffect;
        }
        
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
