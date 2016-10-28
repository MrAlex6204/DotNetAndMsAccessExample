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
            lblErrorMsg.Visible = this.DesignMode;//Mostrar solo en DesignMode
            Configurations.ConfigChange += this.LoadConfig;
            LoadConfig();
        }

        private void LoadConfig() {
            lblCostoCurrency.Text = Configurations.CurrencySymbol;
            lblCurrencySymbol.Text = Configurations.CurrencySymbol;

            txtPrecio.Style.TextPlaceholder = Configurations.CurrencySymbol + " Precio ";
            txtCosto.Style.TextPlaceholder = Configurations.CurrencySymbol + " Costo ";
            this.Invalidate(true);
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
            this.Validate(true);
            Articulo.ID = txtCodigo.Text.Trim();
            Articulo.DESCRIPCION = txtDesc.Text.Trim();
            Articulo.UNIDAD = txtUnidad.Text.Trim();
            Articulo.PRECIO = txtPrecio.Text.Trim();
            Articulo.ES_INVENTARIADO = chkInventario.Checked ? "TRUE" : "FALSE";
            Articulo.COSTO = txtCosto.Text.Trim();


            if (String.IsNullOrEmpty(Articulo.ID)) {
                Functions.Message("EL ID DEL ARTICULO NO PUEDE ESTAR VACIO!", SystemTheme.Danger, this);
                return;
            } else if (String.IsNullOrEmpty(Articulo.PRECIO)) {
                Functions.Message("EL PRECIO DEL ARTICULO NO PUEDE ESTAR VACIO!", SystemTheme.Danger, this);
                return;
            } else if (String.IsNullOrEmpty(Articulo.COSTO)) {
                Functions.Message("EL COSTO DEL ARTICULO NO PUEDE ESTAR VACIO!", SystemTheme.Danger, this);
                return;
            } else if (String.IsNullOrEmpty(Articulo.DESCRIPCION)) {
                Functions.Message("EL LA DESCRIPCION DEL ARTICULO NO PUEDE ESTAR VACIO!", SystemTheme.Danger, this);
                return;
            } else if (String.IsNullOrEmpty(Articulo.UNIDAD)) {
                Functions.Message("LA UNIDAD DEL ARTICULO NO PUEDE ESTAR VACIO!", SystemTheme.Danger, this);
                return;
            }

            if (System.DbRepository.SaveArticulo(Articulo)) {
                if (!Articulo.FOTO.IsEmpty) {
                    //Guardar el Stream de la foto
                    System.DbRepository.GuardarArticuloFoto(txtCodigo.Text, Articulo.FOTO.FSImage);
                }

                Functions.Message("ARTICULO AGREGADO EXITOSAMENTE!!!");
                this.Close();
            } else {
                Functions.Message("NO SE PUDO AGREGAR INFORMACION!", SystemTheme.Danger, this);
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
                txtCosto.Text = Articulo.COSTO;

                if (Articulo.ES_INVENTARIADO.ToUpper() == "TRUE") {
                    chkInventario.Checked = true;
                } else {
                    chkInventario.Checked = false;
                }
                picArticuloFoto.Image = Articulo.FOTO.GetImageSzOf(picArticuloFoto.Size);

                this.Invalidate(true);
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
                lblErrorMsg.Text = "Este codigo ya existe! para el articulo " + Art.DESCRIPCION;
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
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

   

        private void Field_Valid(object sender, CancelEventArgs e) {
            if (!Functions.IsNumber(((TextBox)sender).Text.Trim())) {

                Functions.Message("Valor invalido!", SystemTheme.Danger, this);
                
                ((TextBox)sender).Focus();
                e.Cancel = true;
            }
        }

    }
}
