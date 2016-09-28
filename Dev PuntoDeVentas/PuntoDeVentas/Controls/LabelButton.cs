using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;
using PuntoDeVentas.Controls;
namespace PuntoDeVentas {
    class LabelButton : Button {

        private ControlAppearance _Appearance = new ControlAppearance();        
        private Form _ParentForm = null;
        private Size _NormalSz = new Size();
        private bool _bisFullScreen = false;

        public LabelButton() {            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ControlAppearance Appearance {
            get {

                return _Appearance;
            }
            set {
                _Appearance = value;
                _RenderDesign();
            }
        }
               
        
        private void _MouseHover(object sender, object e) {
            ((Control)sender).ForeColor = _Appearance.MouseOverForecolor;
        }

        private void _MouseLeave(object sender, object e) {
            ((Control)sender).ForeColor = _Appearance.Forecolor;
        }
        

        private void _RenderStyle(ControlAppearance Value) {
            this.ForeColor = Value.Forecolor;
            this.FlatAppearance.BorderColor = Value.BorderColor;
            this.FlatAppearance.BorderSize = Value.BorderSize;
            this.FlatAppearance.CheckedBackColor = Value.CheckedBackColor;
            this.FlatAppearance.MouseDownBackColor = Value.MouseDownBackColor;
            this.FlatAppearance.MouseOverBackColor = Value.MouseOverBackColor;            
        }

        public void _RenderDesign() {

            _RenderStyle(_Appearance);
            _RenderStyle(_Appearance);
            _RenderStyle(_Appearance);
            _RenderStyle(_Appearance);
            _RenderStyle(_Appearance);
            
        }
        
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (this.DesignMode) {
                _RenderDesign();
            }
        }
        
               
               

    }
}
