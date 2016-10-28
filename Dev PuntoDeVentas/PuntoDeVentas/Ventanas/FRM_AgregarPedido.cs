using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuntoDeVentas.Models;

namespace PuntoDeVentas
{
    public partial class FRM_AgregarPedido : Form
    {
        public FRM_AgregarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lblCodigo.Text.Trim()==""){//validamos que alla seleccionado un articulo
                Functions.Message("FAVOR DE SELECCIONAR EL CODIGO DEL ARTICULO!");
            return;
            }
            if(!Functions.IsNumber(txtCantidad.Text)){//validamos que la cantidad tecleada sea numerico
            txtCantidad.Text="";
                txtCantidad.Focus();
                return;
            }

            if (MessageBox.Show("Desea Agregar el pedido?", "Agregar pedido?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                //agregamos el pedido
                if (System.DbRepository.AgregarPedido(System.DbRepository.LoggedUser.Id.ToString(), lblCodigo.Text.Trim(), txtCantidad.Text.Trim(), txtNombre.Text.Trim()))
                {
                    Functions.Message("PEDIDO AGREGADO EXITOSAMENTE!");
                    this.Close();
                }
                else {
                    this.Close();
                }
            }
        }

        private void FRM_AgregarPedido_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void cmdBrow_Click(object sender, EventArgs e)
        {
            FRM_ConsultarArticulos wndConsultarArt = new FRM_ConsultarArticulos();
            wndConsultarArt.ShowDialog(this);

            if (wndConsultarArt.ArticuloId != "") {
                ArticuloInfo Info = new ArticuloInfo();
               Info= System.DbRepository.GetArticuloInfo(wndConsultarArt.ArticuloId);
                if (Info.EXIST)
                { //Si el articulo existe
                    lblCodigo.Text = Info.ID;
                    lblArticulo.Text = Info.DESCRIPCION.ToUpper();
                }
                else {
                    Functions.Message("EL CODIGO DEL ARTICULO NO EXISTE!");
                }
            }

        }
    }
}
