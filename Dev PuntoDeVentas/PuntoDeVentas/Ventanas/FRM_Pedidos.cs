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
    public partial class FRM_Pedidos : Form
    {
        public FRM_Pedidos()
        {
            InitializeComponent();
        }

        #region  <DECLARACIONES>
        private BindingSource _Sources = new BindingSource();
        private DataTable _TblResult = new DataTable();
        #endregion

        #region  <FUNCIONES ESPECIALES>
        void CargarInformacion()
        {
            lblNombre.DataBindings.Clear();
            lblCantidad.DataBindings.Clear();
            lblArticulo.DataBindings.Clear();
            lblFecha.DataBindings.Clear();
            lblNo.DataBindings.Clear();
            cmbStatus.DataBindings.Clear();
            _Sources.DataSource = null;
            _TblResult.Rows.Clear();
            _TblResult = System.DbRepository.GetPedidos();

            if (_TblResult.Rows.Count > 0)
            {
                cmdStatus.Enabled = true;
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdStatus.Enabled = false;
                cmdEliminar.Enabled = false;
            }

            _Sources.DataSource = _TblResult;

            lblNombre.DataBindings.Add("Text", _Sources, "NOMBRE");
            lblCantidad.DataBindings.Add("Text", _Sources, "CANTIDAD");
            lblArticulo.DataBindings.Add("Text", _Sources, "ARTICULO");
            lblFecha.DataBindings.Add("Text", _Sources, "FECHA");
            lblNo.DataBindings.Add("Text", _Sources, "NO");
            cmbStatus.DataBindings.Add("Text", _Sources, "STATUS");
            GridPedidos.DataSource = _Sources;

            foreach (DataGridViewColumn iColumn in GridPedidos.Columns)
            {
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }




        }

        #endregion

        private void FRM_Pedidos_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            CargarInformacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar este pedido?", "Eliminar pedido?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.DbRepository.CambiarStatus(lblNo.Text.Trim(), "ELIMINADO");
                Functions.Message("PEDIDO ELIMINADO!!");
                CargarInformacion();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cambiar el status?", "Cambiar status pedido?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.DbRepository.CambiarStatus(lblNo.Text.Trim(), cmbStatus.Text.Trim().ToUpper());
                Functions.Message("STATUS CAMBIADO!!");
                CargarInformacion();
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            FRM_AgregarPedido wndAgregarPedido = new FRM_AgregarPedido();
            wndAgregarPedido.ShowDialog(this);
            CargarInformacion();//cargamos toda la informacion devuelta para refrescar los nuevos registros agregados.
        }
    }
}
