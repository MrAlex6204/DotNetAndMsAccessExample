using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MES;//USAR ESTE NOMBRE DE ESPACIO PARA EXPORTAR ARCHIVOS A EXCEL
namespace PuntoDeVentas
{
    public partial class FRM_VentaDelDia : Form
    {
        System.DbRepository.VentadelDia VentaDelDia = new System.DbRepository.VentadelDia();

        public FRM_VentaDelDia()
        {
            InitializeComponent();
        }

        private void FRM_VentaDelDia_Load(object sender, EventArgs e)
        {
            VentaDelDia = System.DbRepository.GetVentaDelDia();

            if (VentaDelDia.HayVenta)
            {
                lblTotalArt.Text = VentaDelDia.TotalArticulos.ToString("0.000");
                lblTotal.Text = VentaDelDia.Total.ToString("$ 0.000");
            }
            else
            {
                Functions.Message("NO HAY CORTE DE CAJA REGISTRADAS EL DIA DE HOY!");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MES.EXCEL.ClearExcelList();//LIMPIAMOS LA LISTA          
            VentaDelDia.Articulos.AddToExcelList("ARTICULOS_VENDIDOS");
            VentaDelDia.Cajeros.AddToExcelList("VENTA_DE_CAJEROS");//AGREGAMOS LA INFORMALCION AL REPORTE
            MES.EXCEL.SaveExcelListShowDialog();//GUARDARMOS EL REPORTE

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_VentaDelDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
    }
}
