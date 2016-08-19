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
    public partial class FRM_AgregarArticulo : Form
    {
        public FRM_AgregarArticulo()
        {
            InitializeComponent();
        }

        private void FRM_AgregarArticulo_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtDesc.Focus();
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtUnidad.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                chkInventario.Focus();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.UpdateArticulo(txtCodigo.Text.Trim(), txtDesc.Text.Trim(),txtUnidad.Text, txtPrecio.Text.Trim(), chkInventario.Checked))
            {
                Funciones.Message("ARTICULO AGREGADO EXITOSAMENTE!!!");
                this.Close();
            }
            else {
                Funciones.Message("NO SE PUDO AGREGAR INFORMACION!");
            }
        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPrecio.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ConsultarArticulos wndConsultar = new FRM_ConsultarArticulos();
            System.PuntoDeVentas.ArticuloInfo info = new System.PuntoDeVentas.ArticuloInfo();
            wndConsultar.ShowDialog(this);
            if (wndConsultar.ArticuloId.Trim() != "") {
                info = System.PuntoDeVentas.GetArticuloInfo(wndConsultar.ArticuloId);
                txtCodigo.Text = info.ID;
                txtDesc.Text = info.DESCRIPCION;
                txtPrecio.Text = info.PRECIO;
                txtUnidad.Text = info.UNIDAD;
                if (info.INV.ToUpper() == "TRUE")
                {
                    chkInventario.Checked = true;
                }
                else {
                    chkInventario.Checked = false;
                }
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
    public partial class FRM_AgregarArticulo : Form
    {
        public FRM_AgregarArticulo()
        {
            InitializeComponent();
        }

        private void FRM_AgregarArticulo_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtDesc.Focus();
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtUnidad.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                chkInventario.Focus();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.UpdateArticulo(txtCodigo.Text.Trim(), txtDesc.Text.Trim(),txtUnidad.Text, txtPrecio.Text.Trim(), chkInventario.Checked))
            {
                Funciones.Message("ARTICULO AGREGADO EXITOSAMENTE!!!");
                this.Close();
            }
            else {
                Funciones.Message("NO SE PUDO AGREGAR INFORMACION!");
            }
        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPrecio.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ConsultarArticulos wndConsultar = new FRM_ConsultarArticulos();
            System.PuntoDeVentas.ArticuloInfo info = new System.PuntoDeVentas.ArticuloInfo();
            wndConsultar.ShowDialog(this);
            if (wndConsultar.ArticuloId.Trim() != "") {
                info = System.PuntoDeVentas.GetArticuloInfo(wndConsultar.ArticuloId);
                txtCodigo.Text = info.ID;
                txtDesc.Text = info.DESCRIPCION;
                txtPrecio.Text = info.PRECIO;
                txtUnidad.Text = info.UNIDAD;
                if (info.INV.ToUpper() == "TRUE")
                {
                    chkInventario.Checked = true;
                }
                else {
                    chkInventario.Checked = false;
                }
            }

        }
    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
