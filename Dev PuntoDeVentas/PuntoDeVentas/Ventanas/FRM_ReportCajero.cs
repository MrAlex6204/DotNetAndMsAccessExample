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
    public partial class FRM_ReportCajero : Form
    {
        #region  <DECLARACIONES>  

        string Qry = 
        "SELECT * FROM TBL_VENTAS_X_CAJERO_VIEW WHERE FECHA BETWEEN FORMAT('@START_DATE','SHORT DATE') AND FORMAT('@END_DATE','SHORT DATE')";
        //ventada para ver los reportes
        FRM_ReportView wndReportView = new FRM_ReportView();

        DataTable TblResult = new DataTable();

        #endregion

        




        public FRM_ReportCajero()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            TblResult = System.PuntoDeVentas.Fill(Qry.Replace("@START_DATE", FechaInicial.Text).Replace("@END_DATE", FechaFinal.Text), "Ventas_x_Cajero");
            wndReportView.ReportTitle = "Reporte Ventas x Cajero";
            wndReportView.DataSources = TblResult;
            wndReportView.ShowDialog(this);
        }




    }
}
