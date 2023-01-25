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
    public partial class FRM_Inventario : Form
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
                TblResul = System.PuntoDeVentas.Fill(Qry.Replace("@ART_ID", _Id), "TblResult");
                if (TblResul.Rows.Count > 0)
                {
                    cmdEntrada.Enabled = true;
                    cmdRefresh.Enabled = true;
                    cmdhist.Enabled = true;
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
                    Funciones.Message("EL ARTICULO NO ES PARTE DEL INVENTARIO!");
                    cmdEntrada.Enabled = false;
                    cmdRefresh.Enabled = false;
                    cmdhist.Enabled = false;
                }




            }
            else {
                cmdEntrada.Enabled = false;
                cmdRefresh.Enabled = false;
                cmdhist.Enabled = false;
            }
        }

        private void FRM_Inventario_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            FRM_ConsultarArticulos wndBuscar = new FRM_ConsultarArticulos();
            wndBuscar.ShowDialog(this);
            _Id = wndBuscar.ArticuloId;
            Buscar();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void cmdhist_Click(object sender, EventArgs e)
        {
            FRM_Historial wndHist = new FRM_Historial();
            wndHist.ArticuloId = lblCodigo.Text;
            wndHist.ShowDialog(this);
        }



    }
}
