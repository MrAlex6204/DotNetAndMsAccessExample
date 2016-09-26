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
            this.MouseClick += Click;
            this.pnlLayout.Click += Click;
            this.Modified = true;

            this.OnLostFocus(null);

#if DEBUG
            //Show in the console output window
            TextWriterTraceListener myWriter = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(myWriter);

            TextWriterTraceListener myCreator = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(myCreator);
#endif



        }

        #endregion

        #region Custom Properties

        private int _BorderSize = 4;
        private System.Drawing.Color _BorderColor = Color.Gray;
        private OuterBorderStyle _OuterBorderStyle = OuterBorderStyle.Line;
        private System.Drawing.Drawing2D.DashStyle _BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        private string _Placeholder = string.Empty, _TempValue = string.Empty;


        public enum OuterBorderStyle {
            None = 0,
            Fill = 1,
            Line = 2,
            Both = 3
        }

        public System.Drawing.Drawing2D.DashStyle BorderOuterDashStyle {
            get {
                return _BorderOuterDashStyle;
            }
            set {
                _BorderOuterDashStyle = value;
                DesignerRenderize();
            }
        }

        public OuterBorderStyle BorderOuterStyle {
            get {
                return _OuterBorderStyle;
            }
            set {
                _OuterBorderStyle = value;
                DesignerRenderize();
            }
        }

        public int BorderOuterSize {
            get {
                return _BorderSize;
            }
            set {
                _BorderSize = value;
                DesignerRenderize();//Refrescar el diseno
            }

        }

        public System.Drawing.Color BorderOuterColor {
            get {
                return _BorderColor;
            }
            set {
                _BorderColor = value;
                DesignerRenderize();//Refrescar el diseno
            }
        }

        public string Placeholder {
            get {
                return _Placeholder;
            }
            set {
                _Placeholder = value;

                DesignerRenderize();

            }
        }

        public System.Drawing.Color BorderOuterActiveColor { get; set; }

        #endregion

        #region Functions & Events

        private bool _bGotFocus = false;

        private void DesignerRenderize() {

            if (this.DesignMode) {//Si esta en DesignMode
                this.pnlLayout.CreateGraphics().DrawString(_Placeholder, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
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
            var BorderLocation = new Point(this.Location.X - this.BorderOuterSize, this.Location.Y - BorderOuterSize);
            var BorderSz = new Size(this.Width + (BorderOuterSize * 2), this.Height + (this.BorderOuterSize * 2));
            var BorderBrush = _bGotFocus & this.BorderOuterActiveColor != Color.Empty ? new SolidBrush(this.BorderOuterActiveColor) : new SolidBrush(this.BorderOuterColor);
            var BorderPen = new Pen(BorderBrush);
            var Rect = new Rectangle(BorderLocation, BorderSz);

            BorderPen.DashStyle = this.BorderOuterDashStyle;

            switch (this.BorderOuterStyle) {
                case OuterBorderStyle.Fill:
                    BorderGrap.FillRectangle(BorderBrush, Rect);

                    break;
                case OuterBorderStyle.Line:
                    BorderGrap.DrawRectangle(BorderPen, Rect);

                    break;
                case (OuterBorderStyle.Fill | OuterBorderStyle.Line):

                    BorderGrap.FillRectangle(BorderBrush, Rect);
                    BorderGrap.DrawRectangle(BorderPen, Rect);
                    break;

            }

            //Redraw Textbox region
            BorderGrap.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(this.Location, this.Size));

            if (!_bGotFocus && string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(_Placeholder)) {

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
            g.DrawString(_Placeholder, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
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

        }

        protected override void OnLostFocus(EventArgs e) {
            base.OnLostFocus(e);
            _bGotFocus = false;
            RenderizeBorderColor();
        }

        
        private void Click(object sender, EventArgs e) {            
            _bGotFocus = true;
            this.pnlLayout.Visible = false;
            this.Focus();
            this.Invalidate(true);
        }


        #endregion

    }

}
