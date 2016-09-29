using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PuntoDeVentas.Controls {


    #region APPAREANCE CLASSS
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ControlAppearance {

        private int _BorderSize = 0;
        private Color
                    _MouseOverForecolor = Color.Empty,
                    _Forecolor = Color.Empty,
                    _BorderColor = Color.Empty,
                    _CheckedBackColor = Color.Empty,
                    _MouseDownBackColor = Color.Empty,
                    _MouseOverBackColor = Color.Empty;

        [Description("Define control normal state Text color")]
        public Color Forecolor {
            get {
                return _Forecolor;
            }
            set {
                _Forecolor = value;
            }
        }

        [Description("Control border size")]
        public int BorderSize {
            get {
                return _BorderSize;
            }
            set {
                _BorderSize = value;
            }
        }

        [Description("Border style")]
        public DashStyle BorderStyle { get; set; }

        [Description("Border padding")]
        public int BorderPadding { get; set; }

        [Description("Control border color")]
        public Color BorderColor {
            get {
                return _BorderColor;
            }
            set {
                _BorderColor = value;
            }
        }

        [Description("Active border color")]
        public Color ActiveBorderColor { get; set; }

        [Description("Control backcolor when is checked")]
        public Color CheckedBackColor {
            get {
                return _CheckedBackColor;
            }
            set {
                _CheckedBackColor = value;
            }
        }

        [Description("Set the back color when mouse is down")]
        public Color MouseDownBackColor {
            get {
                return _MouseDownBackColor;
            }
            set {
                _MouseDownBackColor = value;
            }
        }

        [Description("Set the back color when mouse is over the control")]
        public Color MouseOverBackColor {
            get {

                return _MouseOverBackColor;
            }
            set {
                _MouseOverBackColor = value;
            }
        }

        [Description("Define forecolor when the mouse is over")]
        public Color MouseOverForecolor {
            get {

                return _MouseOverForecolor;
            }
            set {
                _MouseOverForecolor = value;
            }
        }

        public override string ToString() {
            return "Style";
        }

    }
    #endregion

}
