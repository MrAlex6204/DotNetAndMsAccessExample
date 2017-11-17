using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas {

    public partial class FRM_ACCESS_LOGIN : PuntoDeVentas.Controls.BaseForm   {
        public FRM_ACCESS_LOGIN() {
            InitializeComponent();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtPassword.Focus();
            }
        }
        
        private void FRM_ACCESS_LOGIN_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) { 
                var Usr = DbRepository.ValidarUsuario(txtUser.Text,txtPassword.Text);

                if (Usr.Exists && Usr.LevelType == "ADMIN") {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                } else {

                    Functions.Message("Accesso negado!", SystemTheme.Warning, this);
                
                }
            }
        }
    }

}
