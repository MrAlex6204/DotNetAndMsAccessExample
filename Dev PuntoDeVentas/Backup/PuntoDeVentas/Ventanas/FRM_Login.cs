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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim()))
            {
                Funciones.Message("BIENVENIDO! "+System.PuntoDeVentas.Nombre.ToUpper());
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Invalido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                button1.Focus();
            }
        }
    }
}
