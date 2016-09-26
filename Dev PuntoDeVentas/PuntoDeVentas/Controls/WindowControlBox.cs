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

        private ControlAppearance _Appearance = new ControlAppearance();
        private Buttons _Buttons = new Buttons();
        private Form _ParentForm = null;
        private Size _NormalSz = new Size();
        private bool _bisFullScreen = false;

        public WindowControlBox() {
            InitializeComponent();
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

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Buttons ControlButtons {
            get {
                return _Buttons;
            }
            set {
                _Buttons = value;
            }
        }
        

        private void _MouseHover(object sender, object e) {
            ((Control)sender).ForeColor = _Appearance.MouseOverForecolor;
        }

        private void _MouseLeave(object sender, object e) {
            ((Control)sender).ForeColor = _Appearance.Forecolor;
        }

        private void _SetFullScreen() {

            if (_ParentForm != null) {

                if (_ParentForm.MaximizeBox) {

                    if (_bisFullScreen) {
                        _ParentForm.WindowState = FormWindowState.Normal;
                    } else {
                        _ParentForm.WindowState = FormWindowState.Maximized;
                    }

                    _bisFullScreen = !_bisFullScreen;
                    _RenderDesign();
                    _ParentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                }

            }

        }

        public void SplitLeft() {

            if (_ParentForm != null) {
                var primaryScreen = Screen.PrimaryScreen.WorkingArea;
                var size = new Size(primaryScreen.Size.Width / 2, primaryScreen.Size.Height);
                this.Size = size;

                if (_bisFullScreen) {
                    _SetFullScreen();
                }

                _ParentForm.Location = new Point(0, 0);

            }
        }

        public void SplitRigth() {

            if (_ParentForm != null) {

                var primaryScreen = Screen.PrimaryScreen.WorkingArea;
                var size = new Size(primaryScreen.Size.Width / 2, primaryScreen.Size.Height);
                this.Size = size;

                if (_bisFullScreen) {
                    _SetFullScreen();
                }

                _ParentForm.Location = new Point(size.Width, 0);

            }
        }

        private void _RenderButtonnFlatStyle(Button Cmd, ControlAppearance Value) {
            Cmd.ForeColor = Value.Forecolor;
            Cmd.FlatAppearance.BorderColor = Value.BorderColor;
            Cmd.FlatAppearance.BorderSize = Value.BorderSize;
            Cmd.FlatAppearance.CheckedBackColor = Value.CheckedBackColor;
            Cmd.FlatAppearance.MouseDownBackColor = Value.MouseDownBackColor;
            Cmd.FlatAppearance.MouseOverBackColor = Value.MouseOverBackColor;            
        }

        public void _RenderDesign() {

            _RenderButtonnFlatStyle(cmdMaximize, _Appearance);
            _RenderButtonnFlatStyle(cmdMinimize, _Appearance);
            _RenderButtonnFlatStyle(cmdClose, _Appearance);
            _RenderButtonnFlatStyle(cmdMoveRight, _Appearance);
            _RenderButtonnFlatStyle(cmdMoveLeft, _Appearance);

            cmdMaximize.Visible = _Buttons.Maximize;
            cmdMinimize.Visible = _Buttons.Minimize;
            pnlMoveWnd.Visible = _Buttons.MoveButtons;
            
            if (_ParentForm != null) {
                if (_ParentForm.WindowState == FormWindowState.Maximized) {
                    cmdMaximize.Text = "2";
                } else {
                    cmdMaximize.Text = "c";
                }

            }
        }
        
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (this.DesignMode) {
                _RenderDesign();
            }
        }
        
        protected override void OnLoad(EventArgs e) {
            _ParentForm = this.FindForm();
            if (_ParentForm != null) {
                _NormalSz = _ParentForm.Size;
            }


            cmdMaximize.MouseHover += _MouseHover;
            cmdMinimize.MouseHover += _MouseHover;
            cmdClose.MouseHover += _MouseHover;
            cmdMoveRight.MouseHover += _MouseHover;
            cmdMoveLeft.MouseHover += _MouseHover;


            cmdMaximize.MouseLeave += _MouseLeave;
            cmdMinimize.MouseLeave += _MouseLeave;
            cmdClose.MouseLeave += _MouseLeave;
            cmdMoveRight.MouseLeave += _MouseLeave;
            cmdMoveLeft.MouseLeave += _MouseLeave;


            base.OnLoad(e);
        }

        private void cmdClose_Click(object sender, EventArgs e) {
            if (_ParentForm != null) {
                _ParentForm.Close();
            }
        }

        private void cmdMaximize_Click(object sender, EventArgs e) {
            if (_ParentForm != null) {
                if (_ParentForm.WindowState == FormWindowState.Normal) {
                    _ParentForm.WindowState = FormWindowState.Maximized;
                } else {
                    _ParentForm.WindowState = FormWindowState.Normal;
                    _ParentForm.Size = _NormalSz;
                    _ParentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                }
                _RenderDesign();
            }
        }

        private void cmdMinimize_Click(object sender, EventArgs e) {
            if (_ParentForm != null) {
                _ParentForm.WindowState = FormWindowState.Minimized;
                _RenderDesign();
            }
        }

        private void cmdMoveRight_Click(object sender, EventArgs e) {
            if (_ParentForm != null) {
                SplitRigth();
            }
        }

        private void cmdMoveLeft_Click(object sender, EventArgs e) {
            if (_ParentForm != null) {
                SplitLeft();
            }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class Buttons {

            public bool Minimize { get; set; }
            public bool Maximize { get; set; }
            public bool MoveButtons { get; set; }

        }


    }
}
