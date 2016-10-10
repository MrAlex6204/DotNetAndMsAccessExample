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
    public partial class FRM_Inventario : Controls.BaseForm
    {
        public FRM_Inventario()
        {
            InitializeComponent();
        }
        BindingSource _Sources = new BindingSource();
        DataTable TblResul = new DataTable();
        string Qry = "SELECT * FROM TBL_INVENTARIO_VIEW WHERE ARTICULO_ID='@ART_ID'";
        string _Id = "";

        void Buscar() {
           

            if (_Id != "")
            {
                lblArticulo.DataBindings.Clear();
                lblCodigo.DataBindings.Clear();
                lblPrecio.DataBindings.Clear();
                lblEntrada.DataBindings.Clear();
                lblSalida.DataBindings.Clear();
                lblStock.DataBindings.Clear();
                lblUnidad.DataBindings.Clear();
                _Sources.DataSource = null;
                TblResul = System.DbRepository.Fill(Qry.Replace("@ART_ID", _Id), "TblResult");
                if (TblResul.Rows.Count > 0)
                {
                    cmdEntrada.Enabled = true;
                    cmdActualizar.Enabled = true;
                    cmdHist.Enabled = true;
                    _Sources.DataSource = TblResul;
                    lblArticulo.DataBindings.Add("Text", _Sources, "DESCRIPCION");
                    lblCodigo.DataBindings.Add("Text", _Sources, "ARTICULO_ID");
                    lblPrecio.DataBindings.Add("Text", _Sources, "PRECIO");
                    lblEntrada.DataBindings.Add("Text", _Sources, "ENTRADA");
                    lblSalida.DataBindings.Add("Text", _Sources, "SALIDA");
                    lblStock.DataBindings.Add("Text", _Sources, "STOCK");
                    lblUnidad.DataBindings.Add("Text", _Sources, "UNIDAD");
                }
                else
                {
                    Functions.Message("EL ARTICULO NO ES PARTE DEL INVENTARIO!");
                    cmdEntrada.Enabled = false;
                    cmdActualizar.Enabled = false;
                    cmdHist.Enabled = false;
                }




            }
            else {
                cmdEntrada.Enabled = false;
                cmdActualizar.Enabled = false;
                cmdHist.Enabled = false;
            }
        }

        private void FRM_Inventario_Load(object sender, EventArgs e)
        {
            this.Invalidate(true);    
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            FRM_ConsultarArticulos wndBuscar = new FRM_ConsultarArticulos();
            wndBuscar.ShowDialog(this);
            _Id = wndBuscar.ArticuloId;
            Buscar();
            this.Invalidate();
        }

        private void cmdRegistrarEntrada_Click(object sender, EventArgs e)
        {
            FRM_RegistrarEntrada wndRegistrarEntrada = new FRM_RegistrarEntrada();
            wndRegistrarEntrada.Articulo = lblArticulo.Text;
            wndRegistrarEntrada.Codigo = lblCodigo.Text;
            wndRegistrarEntrada.ShowDialog(this);
            
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cmdHist_Click(object sender, EventArgs e)
        {
            FRM_Historial wndHist = new FRM_Historial();
            wndHist.ArticuloId = lblCodigo.Text;
            wndHist.ShowDialog(this);
        }



    }
}
