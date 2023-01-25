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
    public partial class FRM_VentanaPrincipal : Form
    {
        public FRM_VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FRM_VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FRM_VentanaPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Punto de Ventas - " + System.PuntoDeVentas.GetConfig("EMPRESA").ToUpper();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Menu wndMenu = new FRM_Menu();
            wndMenu.ShowDialog(this);
        }

        private void tmrFechaYHra_Tick(object sender, EventArgs e)
        {
            lblFechaHra.Text = System.DateTime.Now.ToString("dddd,dd-MMMM-yyyy hh:mm:ss tt");
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_AgregarArticulo wndArticulos = new FRM_AgregarArticulo();
            wndArticulos.ShowDialog(this);
        }

        private void gralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.Tipo.ToUpper() == "ADMIN")
            {
                FRM_Config wndConfig = new FRM_Config();
                wndConfig.ShowDialog(this);
            }
            else
            {
                Funciones.Message("ACCESSO RESTRINGIDO!");
            }
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Inventario wndInventario = new FRM_Inventario();
            wndInventario.ShowDialog(this);
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Login wndLogin = new FRM_Login();
            wndLogin.ShowDialog(this);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.Tipo.ToUpper() == "ADMIN")
            {
                FRM_Usuarios wndUsuarios = new FRM_Usuarios();
                wndUsuarios.ShowDialog(this);
            }
            else
            {
                Funciones.Message("ACCESSO RESTRINGIDO!");
            }
        }

        private void ventasXCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ReportCajero wndReporteCajero = new FRM_ReportCajero();
            wndReporteCajero.ShowDialog(this);
        }

        private void ventasXArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ReportArticulos wndReportArticulos = new FRM_ReportArticulos();
            wndReportArticulos.ShowDialog(this);
        }
    }
}
