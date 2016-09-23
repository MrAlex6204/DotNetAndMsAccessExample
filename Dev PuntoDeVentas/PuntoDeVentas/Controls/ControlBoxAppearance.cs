using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PuntoDeVentas.Controls {


    //[TypeConverter(typeof(ExpandableObjectConverter))]
    //public class ControlAppearance {

    //    private int _BorderSize;
    //    private Color
    //                _Forecolor = Color.Empty,
    //                _BorderColor = Color.Empty,
    //                _CheckedBackColor = Color.Empty,
    //                _MouseDownBackColor = Color.Empty,
    //                _MouseOverBackColor = Color.Empty;
        
    //    public Color Forecolor {
    //        get {
    //            return _Forecolor;
    //        }
    //        set {
    //            _Forecolor = value;
    //        }
    //    }
        
    //    public int BorderSize {
    //        get {
    //            return _BorderSize;
    //        }
    //        set {
    //            _BorderSize = value;
    //        }
    //    }
        
    //    public Color BorderColor {
    //        get {
    //            return _BorderColor;
    //        }
    //        set {
    //            _BorderColor = value;
    //        }
    //    }
        
    //    public Color CheckedBackColor {
    //        get {
    //            return _CheckedBackColor;
    //        }
    //        set {
    //            _CheckedBackColor = value;
    //        }
    //    }
        
    //    public Color MouseDownBackColor {
    //        get {
    //            return _MouseDownBackColor;
    //        }
    //        set {
    //            _MouseDownBackColor = value;
    //        }
    //    }
        
    //    public Color MouseOverBackColor {
    //        get {

    //            return _MouseOverBackColor;
    //        }
    //        set {
    //            _MouseOverBackColor = value;
    //        }
    //    }

    //    public override string ToString() {
    //        return "Style";
    //    }

    //}

    public class ControlAppearanceConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            if (destinationType == typeof(BaseForm.ControlAppearance)) {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {

            return (BaseForm.ControlAppearance)value;
        }


    }




}
