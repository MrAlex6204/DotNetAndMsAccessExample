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
    public partial class FRM_BuscarUsuarios : Form
    {
        #region  <DECLARACIONES>  
        private string _UsrId = "";
        #endregion
        #region  <PROPIEDADES>  
        public string UserId {
            get {
                return _UsrId;
            }
        }
        #endregion
        #region  <FUNCIONES ESPECIALES>  
        void Buscar(string Buscar) {

            DataTable TblResult=  System.PuntoDeVentas.BuscarUsuario(Buscar);
            Gridbuscar.DataSource = TblResult;

            foreach (DataGridViewColumn iColumn in Gridbuscar.Columns)
            {
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            int iCount = 1;
            foreach (DataGridViewRow iRow in Gridbuscar.Rows)
            {
                iRow.HeaderCell.Value = iCount.ToString("00");
                iCount++;
            }
            if (TblResult.Rows.Count <= 0)
            {
                cmdAceptar.Enabled = false;//Deshabilitamos el boton aceptar si no hay registros
            }
            else
            {
                cmdAceptar.Enabled = true;//lo habilitamos si nos trajo mas de un registro
            }


        }
        #endregion

        public FRM_BuscarUsuarios()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (Gridbuscar.SelectedRows.Count > 0)
            {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
                _UsrId = Gridbuscar.SelectedRows[0].Cells["ID"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                Buscar(txtBuscar.Text);
            }
        }
    }
}
