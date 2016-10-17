using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuntoDeVentas.Models;

namespace PuntoDeVentas {
    public partial class FRM_RegistrarEntrada : Controls.BaseForm {

        ArticuloInfo _Articulo;

        public FRM_RegistrarEntrada() {
            InitializeComponent();
        }
        public string ArticuloId {
            set {
                lblArticulo.Text = value;

                _Articulo = DbRepository.GetArticuloInfo(value);


            }
        }


        private void FRM_RegistrarEntrada_Load(object sender, EventArgs e) {
            lblUsr.Text = System.DbRepository.Nombre.ToUpper();

            if (_Articulo != null && !_Articulo.EXIST) {
                Functions.Message("El articulo especificado no existe!", SystemTheme.Danger, this);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            } else {

                lblArticulo.Text = _Articulo.DESCRIPCION;
                lblCodigo.Text = _Articulo.ID;
                lblUnidad.Text = _Articulo.UNIDAD;
                
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e) {
            if (!Functions.IsNumber(txtCantidad.Text)) {
                txtCantidad.Text = "";
                txtCantidad.Focus();
                return;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e) {
            if (txtCantidad.Text.Trim() == "") {
                txtCantidad.Focus();
                return;
            }
            if (MessageBox.Show("Desea registrar la entrada?", "Registro de Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                System.DbRepository.InvRegistrarArticulo(lblCodigo.Text, txtCantidad.Text, "0", System.DbRepository.CajeroId, "*ENTRADA_DE_INVENTARIO**");
                Functions.Message("ENTRADA REGISTRADA EXITOSAMENTE!",SystemTheme.Success,this);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
