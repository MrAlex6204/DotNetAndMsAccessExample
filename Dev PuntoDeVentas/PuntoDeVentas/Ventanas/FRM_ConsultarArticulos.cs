<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_ConsultarArticulos : Form
    {
        public FRM_ConsultarArticulos()
        {
            InitializeComponent();
        }

        private string _ArticuloId = "";

        public string ArticuloId {
            get {
                return _ArticuloId;
            }
        }


        private void Buscar(string Buscar) {
            DataTable TblResults;
            TblResults = System.PuntoDeVentas.BuscarArticulo(Buscar.Trim());
            Gridbuscar.DataSource = TblResults;
            foreach(DataGridViewColumn iColumn in Gridbuscar.Columns){
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;            
            }
            int iCount = 1;
            foreach (DataGridViewRow iRow in Gridbuscar.Rows) {
                iRow.HeaderCell.Value = iCount.ToString("00");
                iCount++;
            }
            if (TblResults.Rows.Count <= 0)
            {
                cmdAceptar.Enabled = false;//Deshabilitamos el boton aceptar si no hay registros
            }
            else {
                cmdAceptar.Enabled = true;//lo habilitamos si nos trajo mas de un registro
                Gridbuscar.Focus();
            }

        }

        private void FRM_ConsultarArticuloscs_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)((int)e.KeyChar)) {
                case Keys.Enter:
                    Buscar(txtBuscar.Text);                                    
                    break;
            }
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FRM_ConsultarArticuloscs_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)((int)e.KeyChar)) {
                case Keys.Enter:
                    if (txtBuscar.Focused) {
                        Buscar(txtBuscar.Text);
                    } else if (Gridbuscar.Focused) {
                        cmdAceptar_Click(null, null);
                    } else {
                        txtBuscar.Focus();
                    }

                    break;
                case Keys.Down | Keys.Up:
                    Gridbuscar.Focus();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    txtBuscar.Focus();
                    break;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (Gridbuscar.SelectedRows.Count > 0) {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
               _ArticuloId = Gridbuscar.SelectedRows[0].Cells["CODIGO"].Value.ToString();
               this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gridbuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
            }
        }
        

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_ConsultarArticulos : Form
    {
        public FRM_ConsultarArticulos()
        {
            InitializeComponent();
        }

        private string _ArticuloId = "";

        public string ArticuloId {
            get {
                return _ArticuloId;
            }
        }


        private void Buscar(string Buscar) {
            DataTable TblResults;
            TblResults = System.PuntoDeVentas.BuscarArticulo(Buscar.Trim());
            Gridbuscar.DataSource = TblResults;
            foreach(DataGridViewColumn iColumn in Gridbuscar.Columns){
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;            
            }
            int iCount = 1;
            foreach (DataGridViewRow iRow in Gridbuscar.Rows) {
                iRow.HeaderCell.Value = iCount.ToString("00");
                iCount++;
            }
            if (TblResults.Rows.Count <= 0)
            {
                cmdAceptar.Enabled = false;//Deshabilitamos el boton aceptar si no hay registros
            }
            else {
                cmdAceptar.Enabled = true;//lo habilitamos si nos trajo mas de un registro
            }

        }

        private void FRM_ConsultarArticuloscs_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                Buscar(txtBuscar.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FRM_ConsultarArticuloscs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (Gridbuscar.SelectedRows.Count > 0) {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
               _ArticuloId = Gridbuscar.SelectedRows[0].Cells["CODIGO"].Value.ToString();
               this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_ConsultarArticulos : Form
    {
        public FRM_ConsultarArticulos()
        {
            InitializeComponent();
        }

        private string _ArticuloId = "";

        public string ArticuloId {
            get {
                return _ArticuloId;
            }
        }


        private void Buscar(string Buscar) {
            DataTable TblResults;
            TblResults = System.PuntoDeVentas.BuscarArticulo(Buscar.Trim());
            Gridbuscar.DataSource = TblResults;
            foreach(DataGridViewColumn iColumn in Gridbuscar.Columns){
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;            
            }
            int iCount = 1;
            foreach (DataGridViewRow iRow in Gridbuscar.Rows) {
                iRow.HeaderCell.Value = iCount.ToString("00");
                iCount++;
            }
            if (TblResults.Rows.Count <= 0)
            {
                cmdAceptar.Enabled = false;//Deshabilitamos el boton aceptar si no hay registros
            }
            else {
                cmdAceptar.Enabled = true;//lo habilitamos si nos trajo mas de un registro
            }

        }

        private void FRM_ConsultarArticuloscs_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                Buscar(txtBuscar.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FRM_ConsultarArticuloscs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (Gridbuscar.SelectedRows.Count > 0) {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
               _ArticuloId = Gridbuscar.SelectedRows[0].Cells["CODIGO"].Value.ToString();
               this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
