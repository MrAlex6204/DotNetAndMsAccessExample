﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MES;//nombre de espacio para exportar a excel
namespace PuntoDeVentas
{
    public partial class FRM_Historial : Controls.BaseForm
    {
        public FRM_Historial()
        {
            InitializeComponent();
        }
        private string Id = "";
        private DataTable TblHist;
        public string ArticuloId {
            set {
                Id = value;
            }
        }

        private void gridHistorial_Load(object sender, EventArgs e)
        {
            TblHist = System.DbRepository.GetInvHistorial(Id);//mandamos a llamar la funcion para ver el historial

            gridResults.DataSource = TblHist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            TblHist.TblToExcel();
        }

    }
}
