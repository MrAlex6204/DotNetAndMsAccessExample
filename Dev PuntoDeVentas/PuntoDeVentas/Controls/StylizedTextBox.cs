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
    class StylizedTextBox : System.Windows.Forms.TextBox {

        #region TextBoxRenderize

        private const int WM_NCPAINT = 0x85;

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);



        protected override void OnPaint(PaintEventArgs e) {
            var BorderGrap = e.Graphics;
            Renderize(ref BorderGrap);

            BorderGrap.Dispose();

        }

        #endregion

        #region Constructor Class

        public StylizedTextBox()
            : base() {

                this.OnLostFocus(null);
                if (this.DesignMode) {
                    SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

                }
           
        }

        #endregion

        #region Custom Properties

        private int _BorderSize = 4;
        private System.Drawing.Color _BorderColor = Color.Gray;
        private OuterBorderStyle _OuterBorderStyle = OuterBorderStyle.Line;
        private System.Drawing.Drawing2D.DashStyle _BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        private string _Placeholder = string.Empty, _TempValue = string.Empty;


        public enum OuterBorderStyle {
            None,
            Fill,
            Line
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


                if (!this.DesignMode) {
                    if (!string.IsNullOrEmpty(_Placeholder) & string.IsNullOrEmpty(this.Text)) {
                        this.Text = _Placeholder;
                    }
                } else {

                    this.CreateGraphics().DrawString(_Placeholder, this.Font, new SolidBrush(Color.Red), new Point(0, 0));

                } 

                DesignerRenderize();
            }
        }

        public System.Drawing.Color BorderOuterActiveColor { get; set; }

        #endregion

        #region Functions & Events

        private bool _bGotFocus = false;


        private void DesignerRenderize() {

            if (this.DesignMode) {//Si esta en DesignMode
                this.Invalidate();
            } else {
                this.Refresh();//Si es en Runtime
            }

        }

        private void Renderize(ref Graphics g) {

            var BorderGrap = g;
            var BorderLocation = new Point(this.Location.X - this.BorderOuterSize, this.Location.Y - BorderOuterSize);
            var BorderSz = new Size(this.Width + (BorderOuterSize * 2), this.Height + (this.BorderOuterSize * 2));            
            var BorderBrush = _bGotFocus ? new SolidBrush(this.BorderOuterActiveColor) : new SolidBrush(this.BorderOuterColor);
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

            if (this.DesignMode) {

                this.CreateGraphics().DrawString(_Placeholder, this.Font, new SolidBrush(this.ForeColor), new Point(1, 1));
            }

        }


        

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT) {
                var hDC = GetWindowDC(this.Parent.Handle);
                var Grph = Graphics.FromHdc(hDC);

                Renderize(ref Grph);

                Grph.Dispose();

            }
                      

        }

        protected override void OnGotFocus(EventArgs e) {
            //base.OnGotFocus(e);

            _bGotFocus = true;

            if (this.Text == _Placeholder) {
                this.Text = "";
            }

            Debug.WriteLine("This " + this.Name + " got focus");

        }

        protected override void OnLeave(EventArgs e) {            
            //base.OnLeave(e);
            _bGotFocus = false;
            Debug.WriteLine("This " + this.Name + " got Leave");
        }

        protected override void OnLostFocus(EventArgs e) {
           // base.OnLostFocus(e);

            _bGotFocus = false;

            Debug.WriteLine("This " + this.Name + " Lost focus");
          

        }


        #endregion


    }

}
