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
    public partial class FRM_Inventario : Controls.BaseForm {

        BindingSource _Source = new BindingSource();
        ArticuloInfo _Articulo = new ArticuloInfo();

        public FRM_Inventario() {
            InitializeComponent();


            _Source.DataSource = _Articulo;

            lblArticulo.DataBindings.Add("Text", _Source, "DESCRIPCION");
            lblCodigo.DataBindings.Add("Text", _Source, "ID");
            lblPrecio.DataBindings.Add("Text", _Source, "PRECIO");
            lblEntrada.DataBindings.Add("Text", _Source, "INVENTARIO.ENTRADA");
            lblSalida.DataBindings.Add("Text", _Source, "INVENTARIO.SALIDA");
            lblStock.DataBindings.Add("Text", _Source, "INVENTARIO.STOCK");
            lblUnidad.DataBindings.Add("Text", _Source, "UNIDAD");

            lblArticulo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblCodigo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblPrecio.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblEntrada.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblSalida.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblStock.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblUnidad.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            Configurations.ConfigChange += this.LoadConfig;
            LoadConfig();

        }

        void Buscar(string ArticuloId) {

            _Articulo.Clear();

            _Articulo = DbRepository.GetArticuloInfo(ArticuloId);
            if (_Articulo.EXIST) {

                if (_Articulo.ES_INVENTARIADO != "False") {
                    _Source.DataSource = _Articulo;
                    var sz = pictArticulo.Size;
                    cmdEliminar.Enabled = true;
                    cmdEntrada.Enabled = true;
                    cmdActualizar.Enabled = true;
                    cmdHist.Enabled = true;
                    pictArticulo.Image = ImageInfo.GetRoundCornersImage(_Articulo.FOTO.GetGrayScaleImageSzOf(sz), 5, Color.Empty);

                } else {

                    Functions.Message("EL ARTICULO NO ES PARTE DEL INVENTARIO!", this.WindowBorderColor, this);
                    cmdEntrada.Enabled = false;
                    cmdActualizar.Enabled = false;
                    cmdHist.Enabled = false;
                    cmdEliminar.Enabled = false;
                }



            } else {

                Functions.Message("NO SE ENCONTRO ARTICULO.\nFAVOR DE VERIFICAR", this.WindowBorderColor, this);
                cmdEntrada.Enabled = false;
                cmdActualizar.Enabled = false;
                cmdHist.Enabled = false;
                cmdEliminar.Enabled = false;

            }
        }

        private void LoadConfig() {
            lblCurrencyCode.Text = Configurations.CurrencyCode;
            lblCurrencySymbol.Text = Configurations.CurrencySymbol;
            this.Invalidate(true);
        }

        private void FRM_Inventario_Load(object sender, EventArgs e) {
            this.Invalidate(true);

        }

        private void cmdSearch_Click(object sender, EventArgs e) {
            FRM_ConsultarArticulos wndBuscar = new FRM_ConsultarArticulos();

            if (wndBuscar.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                Buscar(wndBuscar.ArticuloId);
                this.Invalidate();
            }
        }

        private void cmdRegistrarEntrada_Click(object sender, EventArgs e) {
            FRM_RegistrarEntrada wndRegistrarEntrada = new FRM_RegistrarEntrada();
            wndRegistrarEntrada.Articulo = lblArticulo.Text;
            wndRegistrarEntrada.Codigo = lblCodigo.Text;
            wndRegistrarEntrada.ShowDialog(this);

        }

        private void cmdRefresh_Click(object sender, EventArgs e) {
            Buscar(_Articulo.ID);
        }

        private void cmdHist_Click(object sender, EventArgs e) {
            FRM_Historial wndHist = new FRM_Historial();
            wndHist.ArticuloId = _Articulo.ID;
            wndHist.ShowDialog(this);
        }

        private void cmdEliminar_Click(object sender, EventArgs e) {

        }



    }
}
