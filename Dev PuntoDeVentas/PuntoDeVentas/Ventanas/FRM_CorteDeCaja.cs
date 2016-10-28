using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_CorteDeCaja : Form
    {
        System.DbRepository.CorteDeCajaInfo Info = new System.DbRepository.CorteDeCajaInfo();
        public FRM_CorteDeCaja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_CorteDeCaja_Load(object sender, EventArgs e)
        {

            Info = System.DbRepository.GetCorteDeCaja(System.DbRepository.LoggedUser.Id.ToString());

            if (Info.CajeroExist)
            {
                lblCajero.Text = Info.NomCajero.ToUpper();
                lblTotalArt.Text = Info.TotalArticulos.ToString("0.00");
                lblTotal.Text = Info.Total.ToString("$ 0.000");
            }
            else {
                this.Close();
                Functions.Message("NO HAY VENTAS REGISTRADAS POR EL CAJERO!");
            }

            



        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCorte_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realizar corte de Caja?", "Corte de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                System.DbRepository.CerrarCaja(System.DbRepository.LoggedUser.Id.ToString());
                this.Close();  
                Functions.Message("CORTE DE CAJA REALIZADO EXITOSAMENTE!");
            }
        }

        private void FRM_CorteDeCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
    }
}
