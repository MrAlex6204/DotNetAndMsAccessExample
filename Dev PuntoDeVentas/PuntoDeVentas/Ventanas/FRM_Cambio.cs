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
    public partial class FRM_Cambio : Controls.BaseForm
    {
        private bool _ImprimirTiket = false;
        public FRM_Cambio()
        {
            InitializeComponent();
            txtContinuar.Focus();
        }

        public string Message
        {
            set
            {
                lblMessage.Text = value;
            }
        }
        public bool ImprimirTiket {//Propiedad que nos indica si se va imprimir el tiket
            get {
                return _ImprimirTiket;
            }
        }


        private void txtContinuar_TextChanged(object sender, EventArgs e)
        {
            if (txtContinuar.Text.ToUpper() == "Y")
            {
                _ImprimirTiket = true;
                this.Close();
            }
            if (txtContinuar.Text.ToUpper() == "N")
            {
                _ImprimirTiket = false;
                this.Close();
            }
            else {
                txtContinuar.Text = "";
                txtContinuar.Focus();
            }



        }
    }
}
