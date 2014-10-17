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
        System.PuntoDeVentas.CorteDeCajaInfo Info = new System.PuntoDeVentas.CorteDeCajaInfo();
        public FRM_CorteDeCaja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_CorteDeCaja_Load(object sender, EventArgs e)
        {

            Info = System.PuntoDeVentas.GetCorteDeCaja(System.PuntoDeVentas.CajeroId);

            if (Info.CajeroExist)
            {
                lblCajero.Text = Info.NomCajero.ToUpper();
                lblTotalArt.Text = Info.TotalArticulos.ToString("0.00");
                lblTotal.Text = Info.Total.ToString("$ 0.000");
            }
            else {
                this.Close();
                Funciones.Message("NO HAY VENTAS REGISTRADAS POR EL CAJERO!");
            }

            



        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCorte_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realizar corte de Caja?", "Corte de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                System.PuntoDeVentas.CerrarCaja(System.PuntoDeVentas.CajeroId);
                this.Close();  
                Funciones.Message("CORTE DE CAJA REALIZADO EXITOSAMENTE!");
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
