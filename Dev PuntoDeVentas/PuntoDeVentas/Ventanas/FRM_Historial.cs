<<<<<<< HEAD
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
    public partial class FRM_Historial : Form
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
            TblHist = System.PuntoDeVentas.GetInvHistorial(Id);//mandamos a llamar la funcion para ver el historial

            dataGrid.DataSource = TblHist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            TblHist.TblToExcel();
        }

    }
}
=======
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
    public partial class FRM_Historial : Form
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
            TblHist = System.PuntoDeVentas.GetInvHistorial(Id);//mandamos a llamar la funcion para ver el historial

            dataGrid.DataSource = TblHist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            TblHist.TblToExcel();
        }

    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
