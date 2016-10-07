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
        public FRM_Main() {
            InitializeComponent();
        }

        private void FRM_Main_Load(object sender, EventArgs e) {
            lblTitle.Text = Configurations.NombreDelNegocio;
            lblUserGreetings.Text = "Hello! " + DbRepository.Nombre;
        }

        private void cmdSale_Click(object sender, EventArgs e) {

            using (var wndSale = new FRM_Cbza()) {
                this.Hide();
                wndSale.ShowDialog();
                this.Show();
            }
        }

        private void cmdLock_Click(object sender, EventArgs e) {
            using (var wndLock = new FRM_Login()) {
                this.Hide();
                wndLock.ShowDialog(this);

                if (wndLock.UserIsLoggued) {
                    this.Show();//VOLVER A MOSTRAR SI EL USUARIO ESTA LOGUEADO
                }

            }
        }

        private void cmdConfig_Click(object sender, EventArgs e) {

        }

        private void cmdArticulos_Click(object sender, EventArgs e) {

            using (var wndArticulos = new FRM_AgregarArticulo()) {
                
                wndArticulos.ShowDialog(this);               

            }

        }


    }
}
