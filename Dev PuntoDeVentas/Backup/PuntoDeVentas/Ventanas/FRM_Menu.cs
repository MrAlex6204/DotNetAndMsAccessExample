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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Cbza wndCbza = new FRM_Cbza();
            wndCbza.ShowDialog(this);
            
            
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            cmdCobranza.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Inventario wndInventario = new FRM_Inventario();
            wndInventario.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Pedidos wndPedido = new FRM_Pedidos();
            wndPedido.ShowDialog(this);
        }
    }
}
