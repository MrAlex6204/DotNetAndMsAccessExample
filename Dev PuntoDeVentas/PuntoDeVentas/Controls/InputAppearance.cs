using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace PuntoDeVentas {

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InputAppearance {
        
        public enum DrawStyle {
            None = 0,
            Fill = 1,
            Line = 2,
            Both = 3
        }

        public InputAppearance() {
            this.BorderColor = Color.Gray;
            this.Style = DashStyle.Solid;
            this.TextPlaceholder = String.Empty;
            this.BorderSize = 1;
            this.BorderPadding = 4;
            this.Draw = DrawStyle.Line;
            this.BorderRadius = 2;

        }

        [Description("Input border style")]
        public DashStyle Style { get; set; }

        [Description("Input border draw style")]
        public DrawStyle Draw { get; set; }

        [Description("Input border size ")]
        public int BorderSize { get; set; }

        [Description("Input border padding")]
        public int BorderPadding { get; set; }

        [Description("Input border color ")]
        public Color BorderColor { get; set; }

        [Description("Input active border color")]
        public Color BorderActiveColor { get; set; }

        [Description("Active forecolor")]
        public Color ActiveForecolor { get; set; }

        [Description("Forecolor")]
        public Color Forecolor { get; set; }

        [Description("Active backcolor")]
        public Color ActiveBackcolor { get; set; }

        [Description("Input place holder to display when is empty")]
        public string TextPlaceholder { get; set; }

        [Description("Input border radius")]        
        public int BorderRadius { get; set; }

        public override string ToString() {
            return "(Input style appearance)";
        }



    }
}
