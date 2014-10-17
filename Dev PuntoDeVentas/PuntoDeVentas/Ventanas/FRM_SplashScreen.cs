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
    public partial class FRM_SplashScreen : Form
    {
        public FRM_SplashScreen()
        {
            InitializeComponent();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            System.Threading.Thread.Sleep(1000);
            lblDetalles.Text = "Conectando con la base de datos....";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            lblDetalles.Text = "Validando conexion.................";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
