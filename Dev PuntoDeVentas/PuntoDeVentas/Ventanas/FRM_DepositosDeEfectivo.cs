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
    public partial class FRM_DepositosDeEfectivo : Controls.BaseForm {
        public FRM_DepositosDeEfectivo() {
            InitializeComponent();
            lblMontoLabel.Text = string.Format("Monto del deposito efectuado : {0}", Configurations.CurrencySymbol);
            lblCurrencyCode.Text = Configurations.CurrencyCode;
            txtMonto.Text = DbRepository.LoggedUser.DepositoEnCaja;
            lblCajeroName.Text = string.Format("Cajero: {0}", DbRepository.LoggedUser.Name);

        }

        private void cmdRetirarDeposito_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Desea retirar el deposito del cajero ?", "Retirar ?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                DbRepository.RetirarDeposito(DbRepository.LoggedUser);
                DbRepository.LoggedUser.DepositoEnCaja = "0.00";
                Functions.Message("Retiro de efectivo efectuado!", SystemTheme.Success, this);
                DbRepository.Events.DepositoDeCajaChange("0.00");//Realizar notificacion
                this.Close();
            }
        }

        private void cmdGuardarCambios_Click(object sender, EventArgs e) {

            if (Functions.IsNumber(txtMonto.Text)) {

                if (MessageBox.Show("Desea guardar cambios del deposito del cajero ?", "Guardar?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                    DbRepository.RegistrarDeposito(DbRepository.LoggedUser, float.Parse(txtMonto.Text));
                    Functions.Message("Cambio efectuado!", SystemTheme.Success, this);
                    DbRepository.LoggedUser.DepositoEnCaja = txtMonto.Text;
                    DbRepository.Events.DepositoDeCajaChange(txtMonto.Text);//Realizar notificacion
                    this.Close();
                }

            } else {
                Functions.Message("El monto tiene un formato invalido!",SystemTheme.Warning,this);
            }

        }
    }
}
