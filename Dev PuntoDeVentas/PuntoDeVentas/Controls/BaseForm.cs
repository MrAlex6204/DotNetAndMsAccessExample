using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PuntoDeVentas.Controls {
    public partial class BaseForm : Form {

        #region WINDOWS API PARA MOVER EL FORMULARIO

        private const int WM_NCLBUTTONDOWN = 0xa1;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wndParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void lblPanelTitle_MouseDown(object sender, MouseEventArgs e) {

            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        #endregion

        #region DECLARACIONES

        private bool _bisFullScreen = false, _bIsOpaque = false;
        private Size _normalSize;


        #endregion

        #region PROPERTIES
        public bool MoveWindowBtn { get; set; }
        #endregion

        public BaseForm() {
            MoveWindowBtn = false;
            InitializeComponent();

        }

        public void FullScreenToggle() {

            if (this.MaximizeBox) {

                if (_bisFullScreen) {
                    this.WindowState = FormWindowState.Normal;
                } else {
                    this.WindowState = FormWindowState.Maximized;
                }

                _bisFullScreen = !_bisFullScreen;
                _SetWndIcons();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            }

        }

        public void SplitLeft() {
            var primaryScreen = Screen.PrimaryScreen.WorkingArea;
            var size = new Size(primaryScreen.Size.Width / 2, primaryScreen.Size.Height);
            this.Size = size;

            if (_bisFullScreen) {
                FullScreenToggle();
            }

            this.Location = new Point(0, 0);
        }

        public void SplitRigth() {
            var primaryScreen = Screen.PrimaryScreen.WorkingArea;
            var size = new Size(primaryScreen.Size.Width / 2, primaryScreen.Size.Height);
            this.Size = size;

            if (_bisFullScreen) {
                FullScreenToggle();
            }

            this.Location = new Point(size.Width, 0);
        }

        private void OpaqueWindow() {
            var Rect = new Rectangle(new Point(0, 0), this.Size);
            var Br = new SolidBrush(Color.FromArgb(128, 64, 64, 64));
            var wndGraphic = this.CreateGraphics();
            
            if (!_bIsOpaque) {
                wndGraphic.Clear(Br.Color);
                wndGraphic.FillRectangle(Br, Rect);

                foreach (Control iCtrl in this.Controls) {
                    var iGraphic = iCtrl.CreateGraphics();
                    iGraphic.Clear(Br.Color);
                    iGraphic.FillRectangle(Br, Rect);
                }

            } else {
                this.Refresh();
                
            }

            _bIsOpaque=!_bIsOpaque;


        }
        
        private void _SetWndIcons() {
            pnlControls.Visible = this.ControlBox;
            cmdMaximize.Visible = this.MaximizeBox;
            cmdMinimize.Visible = this.MinimizeBox;
            pnlMoveWnd.Visible = this.MoveWindowBtn;
            if (this.WindowState == FormWindowState.Maximized) {
                cmdMaximize.Text = "2";
            } else {
                cmdMaximize.Text = "c";
            }
        }

        private void cmdClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdMaximize_Click(object sender, EventArgs e) {

            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            } else {
                this.WindowState = FormWindowState.Normal;
                this.Size = _normalSize;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }

            _SetWndIcons();

        }

        private void cmdMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblPanelTitle_DoubleClick(object sender, EventArgs e) {
            FullScreenToggle();
        }

        private void BaseForm_Load(object sender, EventArgs e) {
            _normalSize = this.Size;
            _SetWndIcons();            
            
        }

        private void BaseForm_Paint(object sender, PaintEventArgs e) {
            if (this.DesignMode) {
                _SetWndIcons();
            }

        }

        private void cmdMoveRigth_Click(object sender, EventArgs e) {
            SplitRigth();
        }

        private void cmdMoveLeft_Click(object sender, EventArgs e) {
            SplitLeft();
        }

    }
}
