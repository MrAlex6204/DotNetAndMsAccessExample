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
    public partial class FRM_AgregarArticulo : Controls.BaseForm {
        private ArticuloInfo Articulo = new ArticuloInfo();

        public FRM_AgregarArticulo() {
            InitializeComponent();
            lblErrorMsg.Visible = this.DesignMode;

        }

        private void FRM_AgregarArticulo_Load(object sender, EventArgs e) {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtDesc.Focus();
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtUnidad.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                chkInventario.Focus();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e) {

            Articulo.ID = txtCodigo.Text.Trim();
            Articulo.DESCRIPCION = txtDesc.Text.Trim();
            Articulo.UNIDAD = txtUnidad.Text.Trim();
            Articulo.PRECIO = txtPrecio.Text.Trim();
            Articulo.INV = chkInventario.Checked ? "TRUE" : "FALSE";
            
            if (System.DbRepository.UpdateArticulo(Articulo)) {
                if (!Articulo.FOTO.IsEmpty) {
                    //Guardar el Stream de la foto
                    System.DbRepository.GuardarFoto(txtCodigo.Text,Articulo.FOTO.FSImage);
                }

                Functions.Message("ARTICULO AGREGADO EXITOSAMENTE!!!");
                this.Close();
            } else {
                Functions.Message("NO SE PUDO AGREGAR INFORMACION!");
            }


        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtPrecio.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            FRM_ConsultarArticulos wndConsultar = new FRM_ConsultarArticulos();            
            wndConsultar.ShowDialog(this);

            if (wndConsultar.ArticuloId.Trim() != "") {
                Articulo = System.DbRepository.GetArticuloInfo(wndConsultar.ArticuloId);
                txtCodigo.Text = Articulo.ID;
                txtDesc.Text = Articulo.DESCRIPCION;
                txtPrecio.Text = Articulo.PRECIO;
                txtUnidad.Text = Articulo.UNIDAD;

                if (Articulo.INV.ToUpper() == "TRUE") {
                    chkInventario.Checked = true;
                } else {
                    chkInventario.Checked = false;
                }
                picArticuloFoto.Image = Articulo.FOTO.GetImageSzOf(picArticuloFoto.Size);
            }


        }

        private void cmdExaminar_Click(object sender, EventArgs e) {

            using (var dlg = new OpenFileDialog()) {
                dlg.Title = "Seleccione la foto del articulo";
                dlg.DefaultExt = "Jpeg|*.jpeg,Png|*.png";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK) {
                                        
                    Articulo.FOTO.FSImage = ImageInfo.GetFileStream(dlg.FileName);//Obtiene y guardar el Stream de la foto                    
                    picArticuloFoto.Image = Articulo.FOTO.GetImageSzOf(picArticuloFoto.Size);//Convertir y obtener el Image del stream de la foto.

                }


            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e) {
            var Art = DbRepository.GetArticuloInfo(txtCodigo.Text.Trim());
            
            if (Art.EXIST) {
                txtCodigo.Style.BorderColor = Color.Maroon;
                lblErrorMsg.Text = "Este codigo ya existe! para el articulo "+Art.DESCRIPCION;
                lblErrorMsg.Visible = true;

                picArticuloFoto.Image = Art.FOTO.GetImageSzOf(picArticuloFoto.Size);

            } else {
                txtCodigo.Style.BorderColor = Color.WhiteSmoke;
                lblErrorMsg.Text = "";
                lblErrorMsg.Visible = false;
                picArticuloFoto.Image = null;
            }
        }

        private void FRM_AgregarArticulo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar ==  27) {
                this.Close();
            }
        }

    }
}
