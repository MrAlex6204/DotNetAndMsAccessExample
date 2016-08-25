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
    public partial class FRM_Usuarios : Form
    {
        public FRM_Usuarios()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Usuarios_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUsuario.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rdioUsuario.Focus();
            }
        }

        private void chkCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rdioAdmin.Focus();
            }
        }

        private void chkAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmdGuardar.Focus();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string Tipo = "";
            if (txtNombre.Text.Trim() == "") {
                Funciones.Message("NOMBRE INVALIDO");
                txtNombre.Focus();
                return;
            }
            if (txtUsuario.Text.Trim() == "") {
                Funciones.Message("USUARIO INVALIDO");
                txtUsuario.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                Funciones.Message("CONTRASEÑA INVALIDA");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Trim().ToUpper() != txtConfirmPassword.Text.Trim().ToUpper()) {
                Funciones.Message("CONFIRME BIEN LA CONTRASEÑA!");
                txtPassword.Focus();
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                return;
            }

            if (rdioUsuario.Checked) {
                Tipo = "USUARIO";

            }

            if (rdioAdmin.Checked) {
                Tipo = "ADMIN";
            }

            if (System.PuntoDeVentas.GuardarUsuario(txtNombre.Text, txtUsuario.Text, txtPassword.Text, Tipo))
            {
                Funciones.Message("Usuario agregado exitosamente!");
            }
            else {
                Funciones.Message("Fallo al agregar el usuario");
            }
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            FRM_BuscarUsuarios wndBuscarUsr = new FRM_BuscarUsuarios();
            wndBuscarUsr.ShowDialog(this);

            if (wndBuscarUsr.UserId.Trim() != "") {
                System.PuntoDeVentas.UserInfo UserInfo;
                UserInfo = System.PuntoDeVentas.GetUserInfo(wndBuscarUsr.UserId);

                txtNombre.Text = UserInfo.Nombre;
                txtUsuario.Text = UserInfo.Login;
                txtPassword.Text = UserInfo.Password;
                txtConfirmPassword.Text = UserInfo.Password;
                lblFecha.Text = UserInfo.Fecha;
                if (UserInfo.Tipo.Trim().ToUpper() == "ADMIN")
                {
                    rdioAdmin.Checked = true;
                    rdioUsuario.Checked = false;
                }
                else {
                    rdioUsuario.Checked = true;
                    rdioAdmin.Checked = false;
                }



            }
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
