using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_system
{
    public static class ColorManager
    {
        public static event Action ColorsChanged;

        private static Color _panelColor = Color.FromArgb(247, 247, 255);
        private static Color _panelColor2 = Color.FromArgb(242, 208, 164);

        public static Color PanelColor
        {
            get { return _panelColor; }
            set
            {
                _panelColor = value;
                //ColorsChanged?.Invoke(); // Notify subscribers that colors have changed
            }
        }

        public static Color PanelColor2
        {
            get { return _panelColor2; }
            set
            {
                _panelColor = value;
                //ColorsChanged?.Invoke(); // Notify subscribers that colors have changed
            }
        }
    }

}
