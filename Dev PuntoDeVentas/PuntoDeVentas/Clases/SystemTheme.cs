using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace PuntoDeVentas {
    static class SystemTheme   {

        public static Color Danger {
            get {
                return Color.FromArgb(234, 90, 90);
            }
        }

        public static Color Success {
            get {
                return Color.FromArgb(60, 184, 120);            
            }
        }

        public static Color DarkSuccess {
            get {
                return Color.FromArgb(24, 142, 57);
            }
        }

        public static Color LightSuccess {
            get {
                return Color.FromArgb(33, 190, 74);
            }
        }

        public static Color Warning {

            get {
                return Color.Goldenrod;
            }
        }

        

    }
}

