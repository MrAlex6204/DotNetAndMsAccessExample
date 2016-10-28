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

        #region DECLARACIONES

        private ControlAppearance _Style = new ControlAppearance();
        private Color _Backcolor = Color.Transparent;
        private Color _Forecolor = Color.Empty;
        private bool _bGotFocus = false;

        private const int WM_NCPAINT = 0x85;
        private const int WM_NCCREATE = 0x81;
        private const int WM_MOUSEMOVE = 0x200;

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        #endregion

        #region CONSTRUCTOR CLASS

        public LabelButton() {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            _Renderize();
        }

        #endregion

        #region PROPERTIES



        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ControlAppearance Style {
            get {

                return _Style;
            }
            set {
                _Style = value;
            }
        }

        [Description("Button border radius")]
        public int BorderRadius { get; set; }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor {
            get {

                return base.BackColor;
            }
            set {
                base.BackColor = value;
                _Backcolor = value;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor {
            get {
                return base.ForeColor;
            }
            set {
                base.ForeColor = value;
                _Forecolor = value;
            }
        }

        #endregion

        #region FUNCTIONS


        private void _Renderize() {

            if (this.Parent != null) {
                var hDC = GetWindowDC(this.Parent.Handle);
                var Grph = Graphics.FromHdc(hDC);
                _Renderize(ref Grph);
                Grph.Dispose();
            }

        }

        private void _Renderize(ref Graphics g) {

            if (g != null) {

                var BorderLocation = new Point(this.Location.X - this.Style.BorderPadding - this.Style.BorderSize, this.Location.Y - this.Style.BorderPadding - this.Style.BorderSize);
                var RegionSz = new Size(this.Width + ((this.Style.BorderSize + this.Style.BorderPadding) * 2), this.Height + ((this.Style.BorderSize + this.Style.BorderPadding) * 2));
                var BackgroundBrush = _bGotFocus & this.Style.MouseOverBackColor != Color.Empty ? new SolidBrush(this.Style.MouseOverBackColor) : new SolidBrush(this.Style.BackColor);
                var BorderBrush = _bGotFocus & this.Style.MouseOverBorderColor != Color.Empty ? new SolidBrush(this.Style.MouseOverBorderColor) : new SolidBrush(this.Style.BorderColor);
                var BorderPen = new Pen(BorderBrush);
                var Rect = new RoundedRect(BorderLocation, RegionSz, this.BorderRadius);

                BorderPen.DashStyle = this.Style.BorderStyle;
                BorderPen.Width = this.Style.BorderSize;

                this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.FlatAppearance.BorderColor = Color.Empty;

                //COLOREA EL FONDO DEL CONTROL SI ESTA ACTIVO
                base.BackColor = BackgroundBrush.Color;
                base.ForeColor = _bGotFocus & this.Style.MouseOverForecolor != Color.Empty ? this.Style.MouseOverForecolor : this.Style.Forecolor;
                this.FlatAppearance.MouseOverBackColor = base.BackColor;
                this.FlatAppearance.MouseDownBackColor = BackgroundBrush.Color;

                Rect.FillRoundedRectangle(ref g, BackgroundBrush.Color);
                Rect.DrawRoundedRectangle(ref g, BorderPen);

            }

        }

        protected override void WndProc(ref Message m) {

            if (this.DesignMode && m.Msg == WM_NCPAINT) {

                if (this.Parent != null && this.Parent.IsHandleCreated) {
                    var hDC = GetWindowDC(this.Parent.Handle);
                    var Grph = Graphics.FromHdc(hDC);

                    _Renderize(ref Grph);

                    Grph.Dispose();

                }

            } else if (!this.DesignMode && m.Msg == WM_NCPAINT /*|| m.Msg == WM_MOUSEMOVE || m.Msg == WM_NCCREATE*/) {

                if (this.Parent != null) {
                    var hDC = GetWindowDC(this.Parent.Handle);
                    var Grph = Graphics.FromHdc(hDC);

                    _Renderize(ref Grph);

                    Grph.Dispose();
                }

                if (this.FindForm() != null) {
                    this.FindForm().Load += delegate(object sender, EventArgs e) {
                        //RenderizeBorderColor();
                        //((Control)sender).Invalidate(false);
                        this.OnLostFocus(e);

                    };
                    this.FindForm().Paint += delegate(object sender, PaintEventArgs e) {
                        _Renderize();
                    };

                }

            }

            base.WndProc(ref m);
        }

        protected override void OnMouseHover(EventArgs e) {
            base.OnMouseHover(e);
            _bGotFocus = true;
            _Renderize();

        }

        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            _bGotFocus = false;

            _Renderize();
        }

        #endregion

    }

}
