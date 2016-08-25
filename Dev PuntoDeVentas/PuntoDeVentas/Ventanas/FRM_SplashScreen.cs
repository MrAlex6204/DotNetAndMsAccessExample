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
            lblTitle.Text = System.PuntoDeVentas.GetConfig("EMPRESA").ToUpper();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            pgrBar.Maximum = 100;
            pgrBar.Value = 0;

            lblDetalles.Text = "Estableciendo conexion.................";
            System.Threading.Thread.Sleep(1000);
            pgrBar.Value = 10;
            Application.DoEvents();

            System.Threading.Thread.Sleep(500);
            pgrBar.Value = 25;
            Application.DoEvents();

            System.Threading.Thread.Sleep(250);
            pgrBar.Value = 30;
            Application.DoEvents();

            lblDetalles.Text = "Conectando con la base de datos.........";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            System.Threading.Thread.Sleep(250);
            pgrBar.Value = 45;
            Application.DoEvents();

            System.Threading.Thread.Sleep(250);
            pgrBar.Value = 55;
            Application.DoEvents();


            lblDetalles.Text = "Cargando datos..........................";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            System.Threading.Thread.Sleep(250);
            pgrBar.Value = 65;
            Application.DoEvents();

            System.Threading.Thread.Sleep(150);
            pgrBar.Value = 75;
            Application.DoEvents();

            System.Threading.Thread.Sleep(250);
            pgrBar.Value = 100;
            Application.DoEvents();

            lblDetalles.Text = "Iniciando...............................";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            this.Close();
        }
    }
}
