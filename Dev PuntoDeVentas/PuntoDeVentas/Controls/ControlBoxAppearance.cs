using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PuntoDeVentas.Controls {

    [TypeConverter(typeof(ControlAppearanceConverter))]
    public class ControlAppearance {

        private int _BorderSize;
        private Color 
                    _BorderColor = Color.Empty,
                    _CheckedBackColor = Color.Empty,
                    _MouseDownBackColor = Color.Empty,
                    _MouseOverBackColor = Color.Empty;


        private ControlAppearance() { }

        public static ControlAppearance GetInstance() {
            return new ControlAppearance();
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int BorderSize {
            get {
                return _BorderSize;
            }
            set {
                _BorderSize = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color BorderColor {
            get {
                return _BorderColor;
            }
            set {
                _BorderColor = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color CheckedBackColor {
            get {
                return _CheckedBackColor;
            }
            set {
                _CheckedBackColor = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color MouseDownBackColor {
            get {
                return _MouseDownBackColor;
            }
            set {
                _MouseDownBackColor = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color MouseOverBackColor {
            get {

                return _MouseOverBackColor;
            }
            set {
                _MouseOverBackColor = value;
            }
        }

       

    }

    public class ControlAppearanceConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            if (destinationType == typeof(ControlAppearance)) {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            
            
            return base.ConvertTo(context, culture, value, destinationType);
        }


    }




}
