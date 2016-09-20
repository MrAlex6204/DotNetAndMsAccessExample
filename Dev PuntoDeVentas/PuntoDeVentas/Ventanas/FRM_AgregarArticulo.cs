﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuntoDeVentas.Models;

namespace PuntoDeVentas
{
    public partial class FRM_AgregarArticulo : Controls.BaseForm
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
            if (e.KeyChar == 13)
            {
                txtDesc.Focus();
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUnidad.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                chkInventario.Focus();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (System.DbRepository.UpdateArticulo(txtCodigo.Text.Trim(), txtDesc.Text.Trim(), txtUnidad.Text, txtPrecio.Text.Trim(), chkInventario.Checked))
            {
                if (txtExaminar.Tag != null)
                {
                    System.DbRepository.GuardarFoto(txtCodigo.Text, txtExaminar.Tag);

                }

                Functions.Message("ARTICULO AGREGADO EXITOSAMENTE!!!");
                this.Close();
            }
            else
            {
                Functions.Message("NO SE PUDO AGREGAR INFORMACION!");
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
            ArticuloInfo info = new ArticuloInfo();
            wndConsultar.ShowDialog(this);
            if (wndConsultar.ArticuloId.Trim() != "")
            {
                info = System.DbRepository.GetArticuloInfo(wndConsultar.ArticuloId);
                txtCodigo.Text = info.ID;
                txtDesc.Text = info.DESCRIPCION;
                txtPrecio.Text = info.PRECIO;
                txtUnidad.Text = info.UNIDAD;
                if (info.INV.ToUpper() == "TRUE")
                {
                    chkInventario.Checked = true;
                }
                else
                {
                    chkInventario.Checked = false;
                }

            }

        }

        private void k(object sender, EventArgs e)
        {

        }

        private void txtExaminar_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Seleccione la foto del articulo";
                dlg.DefaultExt = "Jpeg|*.jpeg,Png|*.png";
                dlg.Multiselect = false;
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    txtExaminar.Text = dlg.FileName;
                    txtExaminar.Tag = dlg.OpenFile();

                }


            }
        }
    }
}
