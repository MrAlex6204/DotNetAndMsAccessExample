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

        #region DECLARACIONES

        BindingSource _Source = new BindingSource();
        ArticuloInfo _Articulo = new ArticuloInfo();

        public FRM_Inventario() {//CONSTRUCTOR DE CLASE INICIALIZAR LA CONFIGURACION AL CREAR LA INSTANCIA
            InitializeComponent();

            _Source.DataSource = _Articulo;


            //REALIZAMOS EL DATA BINDING DEL OBJETO ARTICULO CON RELACION A LOS CONTROLES
            lblArticulo.DataBindings.Add("Text", _Source, "DESCRIPCION");
            lblCodigo.DataBindings.Add("Text", _Source, "ID");
            lblPrecio.DataBindings.Add("Text", _Source, "PRECIO");
            lblEntrada.DataBindings.Add("Text", _Source, "INVENTARIO.ENTRADA");
            lblSalida.DataBindings.Add("Text", _Source, "INVENTARIO.SALIDA");
            lblStock.DataBindings.Add("Text", _Source, "INVENTARIO.STOCK");
            lblInversion.DataBindings.Add("Text", _Source, "INVENTARIO.INVERSION");
            lblStatus.DataBindings.Add("Text", _Source, "INVENTARIO.STATUS_DESC");
            lblUnidad.DataBindings.Add("Text", _Source, "UNIDAD");
            lblEntradaUnidad.DataBindings.Add("Text", _Source, "UNIDAD");
            lblSalidaUnidad.DataBindings.Add("Text", _Source, "UNIDAD");
            lblStockUnidad.DataBindings.Add("Text", _Source, "UNIDAD");
            lblCosto.DataBindings.Add("Text", _Source, "COSTO");
            lblGanancia.DataBindings.Add("Text", _Source, "INVENTARIO.GANANCIA_GENERADA");


            //REALIZAR EL UPDATE DE LA INFORMACION AL CAMBIAR LOS VALORES DE LAS PROPIEDADES DEL OBJETO ARTICULO
            lblArticulo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblCodigo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblPrecio.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblEntrada.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblSalida.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblStock.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblInversion.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblStatus.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblUnidad.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblEntradaUnidad.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblSalidaUnidad.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblStockUnidad.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblGanancia.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            lblCosto.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;


            _LoadConfig();

            //REGISTRAR EVENTOS DEL SISTEMA
            Configurations.ConfigChange += this._LoadConfig;

            DbRepository.Events.OnInventarioChange += this._UpdateInfo;



        }

        #endregion

        #region FUNCIONES

        void _LoadArticuloInfo(string ArticuloId) {
            var Inv_Articulo = DbRepository.GetArticuloInfo(ArticuloId);

            if (Inv_Articulo.EXIST) {

                _Articulo = Inv_Articulo;//ACTUALIZAR INFORMACION

                lblStatus.ForeColor = _Articulo.INVENTARIO.DISPONIBLE ? SystemTheme.Success : SystemTheme.Danger;

                if (_Articulo.ES_INVENTARIADO != "False") {

                    //ACTUALIZAR INFORMACION DEL DATASOURCE PARA MOSTRAR LA INFORMACION EN PANTALLA
                    _Source.DataSource = _Articulo;

                    var sz = pictArticulo.Size;
                    lnkRemoverArticulo.Enabled = true;
                    cmdEntrada.Enabled = true;
                    cmdActualizar.Enabled = true;
                    cmdHist.Enabled = true;
                    pictArticulo.Image = _Articulo.FOTO.FSImage.GetImageSzOf(sz).GetRoundCornersImage(5, this.BackColor);

                } else {

                    Functions.Message("EL ARTICULO NO ES PARTE DEL INVENTARIO!", this.WindowBorderColor, this);
                    cmdEntrada.Enabled = false;
                    cmdActualizar.Enabled = false;
                    cmdHist.Enabled = false;
                    lnkRemoverArticulo.Enabled = false;
                }



            } else {

                Functions.Message("NO SE ENCONTRO ARTICULO.\nFAVOR DE VERIFICAR", this.WindowBorderColor, this);
                cmdEntrada.Enabled = false;
                cmdActualizar.Enabled = false;
                cmdHist.Enabled = false;
                lnkRemoverArticulo.Enabled = false;

            }
        }

        private void _LoadConfig() {
            lblCostoSymbol.Text = Configurations.CurrencySymbol;
            lblCurrencySymbol.Text = Configurations.CurrencySymbol;
            lblCostoCurrencySymbol.Text = Configurations.CurrencySymbol;
            lblGanciaSymbol.Text = Configurations.CurrencySymbol;
            this.Invalidate(true);
        }

        private void _UpdateInfo() {

            if (!string.IsNullOrEmpty(_Articulo.ID)) {
                _LoadArticuloInfo(_Articulo.ID);
            }

        }

        private void _Clear() {

            _Articulo.Clear();
            _Source.DataSource = _Articulo;

            lblArticulo.Text = string.Empty;
            lblCodigo.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblEntrada.Text = string.Empty;
            lblSalida.Text = string.Empty;
            lblStock.Text = string.Empty;
            lblUnidad.Text = string.Empty;

            cmdEntrada.Enabled = false;
            cmdActualizar.Enabled = false;
            cmdHist.Enabled = false;
            lnkRemoverArticulo.Enabled = false;
            pictArticulo.Image = null;

        }

        #endregion

        #region EVENTOS DEL FORMULARIO

        private void FRM_Inventario_Load(object sender, EventArgs e) {
            this.Invalidate(true);
        }

        private void cmdSearch_Click(object sender, EventArgs e) {
            FRM_ConsultarArticulos wndBuscar = new FRM_ConsultarArticulos();

            if (wndBuscar.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                _LoadArticuloInfo(wndBuscar.ArticuloId);
                this.Invalidate();
            }
        }

        private void cmdRegistrarEntrada_Click(object sender, EventArgs e) {
            FRM_RegistrarEntrada wndRegistrarEntrada = new FRM_RegistrarEntrada();
            wndRegistrarEntrada.ArticuloId = _Articulo.ID;
            if (wndRegistrarEntrada.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                _LoadArticuloInfo(_Articulo.ID);
            }


        }

        private void cmdRefresh_Click(object sender, EventArgs e) {
            _UpdateInfo();
        }

        private void cmdHist_Click(object sender, EventArgs e) {
            BaseListWindow wndHist = new BaseListWindow("Historial  -  Registro de Inventario");
            DataTable Source = DbRepository.GetInvHistorial(_Articulo.ID);

            wndHist.DataSource = Source;
            wndHist.ShowDialog(this);
        }

        private void cmdEliminar_Click(object sender, EventArgs e) {

        }

        private void lnkRemoverArticulo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            if (MessageBox.Show("Desea remover este articulo del sistema de inventario ?", "Remover ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

                if (DbRepository.RemoverDelInventario(_Articulo)) {
                    //LIMPIAR Y ACTUALIZAR EL DATA SOURCE
                    _Clear();
                    Functions.Message("ARTICULO ELIMINADO DEL SISTEMA DE INVENTARIO!", Color.FromArgb(60, 184, 120), this);

                } else {

                    Functions.Message("NO SE PUEDO ELIMINAR ARTICULO DEL SISTEMA DE INVENTARIO.\nFAVOR DE VERIFICAR", this.WindowBorderColor, this);
                }

            }

        }

        #endregion


    }
}
