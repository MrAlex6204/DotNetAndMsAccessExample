using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PuntoDeVentas.Controls {
    public partial class WindowControlBox : UserControl {

        private BaseForm.ControlAppearance _Appearance = new BaseForm.ControlAppearance();

        public WindowControlBox() {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }



        public BaseForm.ControlAppearance Appearance {
            get {
                return _Appearance;
            }
            set {
                _Appearance = value;
            }
        }

    }
}
