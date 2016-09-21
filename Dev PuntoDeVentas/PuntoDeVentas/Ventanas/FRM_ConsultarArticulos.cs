﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {
    public partial class FRM_ConsultarArticulos : Controls.BaseForm {
        public FRM_ConsultarArticulos() {
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
            TblResults = System.DbRepository.BuscarArticulo(Buscar.Trim());
            Gridbuscar.DataSource = TblResults;
            foreach (DataGridViewColumn iColumn in Gridbuscar.Columns) {
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (iColumn.Name == "FOTO") {
                    iColumn.Visible = false;
                }
            }

            if (TblResults.Rows.Count > 0) {
                Gridbuscar.Focus();

            }

        }

        private void FRM_ConsultarArticuloscs_Load(object sender, EventArgs e) {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e) {
            switch ((Keys)((int)e.KeyChar)) {
                case Keys.Enter:
                    Buscar(txtBuscar.Text);
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            Buscar(txtBuscar.Text);
        }

        private void FRM_ConsultarArticuloscs_KeyPress(object sender, KeyPressEventArgs e) {
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

        private void cmdAceptar_Click(object sender, EventArgs e) {
            if (Gridbuscar.SelectedRows.Count > 0) {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
                _ArticuloId = Gridbuscar.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Gridbuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
            }
        }

        private void SelectedRow_Change(object sender, EventArgs e) {

            if (Gridbuscar.SelectedRows.Count > 0) {

                //OBTENEMOS EL STREAM DE LA FOTO DEL VALOR DE LA CELDA QUE SE ENCUENTRA EN EL GRID
                var Fs = Gridbuscar.SelectedRows[0].Cells["FOTO"].Value;
                var Sz = pictArticulo.Size;//OBTENEMOS EL SIZE DEL PICTUREBOX

                pictArticulo.Image = ImageInfo.GetImageSzOf((byte[])Fs, Sz);

            }


        }


    }
}
