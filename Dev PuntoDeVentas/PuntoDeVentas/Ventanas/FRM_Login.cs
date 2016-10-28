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

        
        private Models.UserInfo _Usr = new Models.UserInfo();


        public Models.UserInfo  User{
            get {
                return _Usr;
            }
        }



        public FRM_Login() {
            InitializeComponent();
                       
        }
                   


        private void Input_KeyDown(object sender, KeyEventArgs e) {
            var input = (TextBox)sender;


            if (e.KeyCode == Keys.Enter && input == txtUser) {
                txtPassword.Focus();
            }else if (e.KeyCode == Keys.Enter && input == txtPassword) {

                _Usr.Clear();

                _Usr = System.DbRepository.ValidarUsuario(txtUser.Text.Trim(), txtPassword.Text.Trim());

                //VALIDAR USER Y PASSWORD
                if (_Usr.Exists) {
                    this.Hide();
                    lblErrorMsg.Visible = false;                                        
                    Functions.Message("BIENVENIDO " + _Usr.Name, Color.FromArgb(60, 184, 120), this);
                    this.Close();
                } else {                    
                    lblErrorMsg.Visible = true;
                    lblErrorMsg.Text = "Usuario Invalido!";
                    txtPassword.Focus();
                }
            } else if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }

        }

        private void FRM_Login_Load(object sender, EventArgs e) {
            this.Activate();            
        }

        private void label3_Click(object sender, EventArgs e) {

        }
                     


    }
}
