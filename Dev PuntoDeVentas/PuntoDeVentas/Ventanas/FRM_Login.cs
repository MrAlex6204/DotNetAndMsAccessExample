using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {
    public partial class FRM_Login : Controls.BaseForm {

        private bool _bUserIsLogged = false;


        public bool UserIsLoggued {
            get {
                return _bUserIsLogged;
            }
        }

        public FRM_Login() {
            InitializeComponent();
            txtPassword.GotFocus += GotFocus;
            txtPassword.Leave += FocusLeave;

            txtUsuario.GotFocus += GotFocus;
            txtUsuario.Leave += FocusLeave;


        }



        private void input_click(object sender, MouseEventArgs e) {

            var input = (TextBox)sender;

            if (input.Text.Trim() == input.Tag.ToString()) {
                input.Text = "";
            }

        }

        private void GotFocus(object sender, object e) {
            var input = (TextBox)sender;

            if (input.Text.Trim() == input.Tag.ToString()) {
                input.Text = "";
            }

        }
        private void FocusLeave(object sender, object e) {
            var input = (TextBox)sender;

            if (string.IsNullOrEmpty(input.Text.Trim())) {
                input.Text = input.Tag.ToString();
            }

        }


        private void Input_KeyDown(object sender, KeyEventArgs e) {
            var input = (TextBox)sender;

            if (e.KeyCode == Keys.Enter && input == txtPassword) {
                //Validar user y password
                if (System.DbRepository.ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim())) {
                    Functions.Message("BIENVENIDO! " + System.DbRepository.Nombre.ToUpper());
                    _bUserIsLogged = true;
                    this.Close();
                } else {
                    _bUserIsLogged = false;
                    MessageBox.Show("Usuario Invalido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }
            } else if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }

        }


    }
}
