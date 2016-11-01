using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas {


    public partial class FRM_Main : Controls.BaseForm {

        #region DECLARACIONES

        FRM_AgregarArticulo wndArticulos = new FRM_AgregarArticulo();
        FRM_ConsultarArticulos wndSearch = new FRM_ConsultarArticulos();
        FRM_Config wndConfig = new FRM_Config();
        FRM_Inventario wndInventario = new FRM_Inventario();

        public FRM_Main() {
            InitializeComponent();

            //ADJUNTAR EVENTO PARA NOTIFICAR QUE SE NOTIFICARON CAMBIOS
            System.Configurations.ConfigChange += this.ConfigurationChange_Event;
            DbRepository.Events.OnInventarioChange += _Inversion;
            DbRepository.Events.OnVentaRegistradaChange += _Inversion;
        }

        #endregion

        #region EVENTOS DEL FORMULARIO

        private void ConfigurationChange_Event() {
            //RECARGAR LA CONFIGURACION SI SE REALIZARON CAMBIOS 
            _LoadConfig();
        }

        private void FRM_Main_Load(object sender, EventArgs e) {
            _LoadConfig();
            _Inversion();
        }

        private void cmdSale_Click(object sender, EventArgs e) {

            using (var wndSale = new FRM_Cbza()) {
                this.Visible = false;
                wndSale.ShowDialog();
                this.Visible = true;
            }
        }

        private void cmdLock_Click(object sender, EventArgs e) {
            using (var wndLock = new FRM_Login()) {
                this.Hide();
                wndLock.ShowDialog(this);

                if (wndLock.User.Exists) {
                    DbRepository.LoggedUser = wndLock.User;
                    this.Show();//VOLVER A MOSTRAR SI EL USUARIO ESTA LOGUEADO
                }

            }
        }

        private void cmdConfig_Click(object sender, EventArgs e) {
            wndConfig = new FRM_Config();
            _DisplayWindow(wndConfig);
        }

        private void cmdArticulos_Click(object sender, EventArgs e) {

            wndArticulos = new FRM_AgregarArticulo();
            _DisplayWindow(wndArticulos);

        }

        private void cmdSearch_Click(object sender, EventArgs e) {

            wndSearch = new FRM_ConsultarArticulos();
            _DisplayWindow(wndSearch);

        }

        private void cmdWarehouse_Click(object sender, EventArgs e) {
            wndInventario = new FRM_Inventario();
            _DisplayWindow(wndInventario);
        }

        private void lnkInversionDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var wndInversionDetail = new BaseListWindow("Inversion en Inventario")){
                wndInversionDetail.DataSource = DbRepository.GetInversionDetalle();

                wndInversionDetail.ShowDialog(this);


            }
        }

        #endregion

        #region FUNCIONES

        private void _DisplayWindow(Controls.BaseForm Wnd) {

            Wnd.WindowBorderColor = Wnd.BackColor;
            Wnd.EnableWindowDrag = false;//DESHABILITAR EL ARRASTRE CON EL CURSOR
            Wnd.MdiParent = this;
            pnlContainer.Controls.Add(Wnd);
            Wnd.WindowState = FormWindowState.Maximized;
            Wnd.Show();
        }

        private void _LoadConfig() {
            lblTitle.Text = Configurations.NombreDelNegocio;
            lblDireccion.Text = Configurations.Direccion;
            lblUserGreetings.Text = "Hello! " + DbRepository.LoggedUser.Name;

            if (!DbRepository.LoggedUser.Picture.IsEmpty) {
                picUser.Image = DbRepository.LoggedUser.Picture.GetGrayScaleImageSzOf(picUser.Size).GetTintImage(0f, 0.36f, 0f);
                picUser.BackColor = Color.Transparent;

            }

        }

        private void _Inversion() {
            lblInversion.Text = Functions.ToCurrency(DbRepository.GetInversionEnInventario());
        }

        #endregion



    }
}
