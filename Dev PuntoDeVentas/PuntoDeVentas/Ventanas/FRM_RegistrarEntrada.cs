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
    public partial class FRM_RegistrarEntrada : Form
    {
        public FRM_RegistrarEntrada()
        {
            InitializeComponent();
        }
        public string Articulo {
            set {
                lblArticulo.Text = value;
            }
        }
        public string Codigo {
            set {
                lblCodigo.Text = value;
            }
        }

        private void FRM_RegistrarEntrada_Load(object sender, EventArgs e)
        {
            lblUsr.Text = System.PuntoDeVentas.Nombre.ToUpper();
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (!Funciones.IsNumber(txtCantidad.Text))
             {
                txtCantidad.Text = "";
                txtCantidad.Focus();
                return;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCorte_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == "") {
                txtCantidad.Focus();
                return;
            }
            if (MessageBox.Show("Desea registrar la entrada?", "Registro de Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                System.PuntoDeVentas.InvRegistrarArticulo(lblCodigo.Text, txtCantidad.Text, "0", System.PuntoDeVentas.CajeroId, "*ENTRADA_DE_INVENTARIO**");
                Funciones.Message("ENTRADA REGISTRADA EXITOSAMENTE!");
                this.Close();
            }
        }
    }
}
