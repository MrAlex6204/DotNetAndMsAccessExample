using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PuntoDeVentas.Controls {
    class InputTextBox : System.Windows.Forms.TextBox {

        #region TextBoxRenderize

        private const int WM_NCPAINT = 0x85;
        private const int WM_NCCREATE = 0x81;
        private const int WM_MOUSEMOVE = 0x200;


        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);


        #endregion

        #region Constructor Class
        //Dummy Panel used to draw over the TextBox
        private Panel pnlLayout = new Panel();
        private Color _Backcolor = Color.Empty;
        private Color _Forecolor = Color.Empty;

        public InputTextBox()
            : base() {

            if (this.DesignMode) {
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            }
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.pnlLayout);

            this.pnlLayout.Size = this.Size;
            this.pnlLayout.Dock = DockStyle.Fill;
            this.pnlLayout.Location = new Point(0, 0);
            this.pnlLayout.Paint += LayoutPaint;
            this.pnlLayout.Name = "Layout";
            this.Click += MouseClick;
            this.pnlLayout.Click += MouseClick;
            this.Modified = true;

            this.OnLostFocus(null);

        }

        #endregion

        #region Custom Properties


        private InputAppearance _InputStyle = new InputAppearance();

        [Description("Input style preference")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public InputAppearance Style {
            get {
                return _InputStyle;
            }
            set {
                _InputStyle = value;
                DesignerRenderize();
            }
        }

        public override Color BackColor {
            get {
                return base.BackColor;
            }

            set {
                base.BackColor = value;
                _Backcolor = value;
            }
        }

        public override Color ForeColor {
            get {
                return base.ForeColor;
            }

            set {
                base.ForeColor = value;
                _Forecolor = value;
                DesignerRenderize();
            }
        }

        #endregion

        #region Functions & Events

        private bool _bGotFocus = false;

        private void DesignerRenderize() {

            if (this.DesignMode) {//Si esta en DesignMode
                this.pnlLayout.CreateGraphics().DrawString(this.Style.TextPlaceholder, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
                this.Invalidate(true);
                if (this.FindForm() != null) {
                    this.FindForm().Invalidate(false);
                }

            } else {
                this.Refresh();//Si es en Runtime
            }

        }

        private void Renderize(ref Graphics g) {

            var BorderGrap = g;
            var BorderLocation = new Point(this.Location.X - this.Style.BorderPadding - this.Style.BorderSize, this.Location.Y - this.Style.BorderPadding - this.Style.BorderSize);
            var RegionSz = new Size(this.Width + ((this.Style.BorderSize + this.Style.BorderPadding) * 2), this.Height + ((this.Style.BorderSize + this.Style.BorderPadding) * 2));
            var BackBrush = _bGotFocus & this.Style.ActiveBackcolor != Color.Empty ? new SolidBrush(this.Style.ActiveBackcolor) : new SolidBrush(_Backcolor);
            var BorderBrush = _bGotFocus & this.Style.BorderActiveColor != Color.Empty ? new SolidBrush(this.Style.BorderActiveColor) : new SolidBrush(this.Style.BorderColor);
            var BorderPen = new Pen(BorderBrush);
            var Rect = new RoundedRect(BorderLocation, RegionSz, this.Style.BorderRadius);

            BorderPen.DashStyle = this.Style.Style;
            BorderPen.Width = this.Style.BorderSize;


            //Colorea el fondo del control si esta activo
            base.BackColor = _bGotFocus & this.Style.ActiveBackcolor != Color.Empty ? this.Style.ActiveBackcolor : _Backcolor;
            base.ForeColor = _bGotFocus & this.Style.ActiveForecolor != Color.Empty ? this.Style.ActiveForecolor : _Forecolor;


            switch (this.Style.Draw) {
                case InputAppearance.DrawStyle.Fill:

                    Rect.FillRoundedRectangle(ref BorderGrap, base.BackColor);
                    break;
                case InputAppearance.DrawStyle.Line:

                    Rect.DrawRoundedRectangle(ref BorderGrap, BorderPen);
                    break;
                case (InputAppearance.DrawStyle.Fill | InputAppearance.DrawStyle.Line):

                    Rect.FillRoundedRectangle(ref BorderGrap, base.BackColor);
                    Rect.DrawRoundedRectangle(ref BorderGrap, BorderPen);
                    break;
            }

            //Redraw Textbox region
            BorderGrap.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(this.Location, this.Size));

            if (!_bGotFocus && string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(this.Style.TextPlaceholder)) {

                this.pnlLayout.Visible = true;

            } else {

                this.pnlLayout.Visible = false;

                this.Invalidate();
            }


        }

        private void RenderizeBorderColor() {

            if (this.Parent != null) {
                var hDC = GetWindowDC(this.Parent.Handle);
                var Grph = Graphics.FromHdc(hDC);
                Renderize(ref Grph);
                Grph.Dispose();
            }

        }

        protected override void WndProc(ref Message m) {

            if (this.DesignMode && m.Msg == WM_NCPAINT) {

                if (this.Parent != null && this.Parent.IsHandleCreated) {
                    var hDC = GetWindowDC(this.Parent.Handle);
                    var Grph = Graphics.FromHdc(hDC);

                    Renderize(ref Grph);

                    Grph.Dispose();
                }

            } else if (!this.DesignMode && m.Msg == WM_NCPAINT || m.Msg == WM_MOUSEMOVE || m.Msg == WM_NCCREATE) {

                if (this.Parent != null) {
                    var hDC = GetWindowDC(this.Parent.Handle);
                    var Grph = Graphics.FromHdc(hDC);

                    Renderize(ref Grph);

                    Grph.Dispose();
                }

                if (this.FindForm() != null) {
                    this.FindForm().Load += delegate(object sender, EventArgs e) {
                        //RenderizeBorderColor();
                        //((Control)sender).Invalidate(false);
                        this.OnLostFocus(e);

                    };
                    this.FindForm().Paint += delegate(object sender, PaintEventArgs e) {
                        RenderizeBorderColor();
                    };

                }

            }


            base.WndProc(ref m);

        }

        private void LayoutPaint(object sender, PaintEventArgs e) {

            RenderizeBorderColor();
            var g = e.Graphics;
            g.DrawString(this.Style.TextPlaceholder, this.Font, new SolidBrush(_Forecolor), new Point(0, 0));
        }

        protected override void OnGotFocus(EventArgs e) {
            base.OnGotFocus(e);
            _bGotFocus = true;
            //if (this.Text.Trim() == _Placeholder.Trim()) {
            //    this.Text = "";
            //}
            RenderizeBorderColor();
        }

        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);
            _bGotFocus = false;
            RenderizeBorderColor();
            this.Invalidate();

        }

        protected override void OnLostFocus(EventArgs e) {
            base.OnLostFocus(e);
            _bGotFocus = false;
            RenderizeBorderColor();
            this.Invalidate();
        }

        private void MouseClick(object sender, EventArgs e) {
            _bGotFocus = true;
            this.pnlLayout.Visible = false;
            this.Focus();
            this.Invalidate(true);
        }

        #endregion

    }

}
