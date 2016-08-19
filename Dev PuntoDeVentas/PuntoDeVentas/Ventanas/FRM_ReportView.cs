<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MES;//nombre de espacio para guardar en excel

namespace PuntoDeVentas
{
    public partial class FRM_ReportView : Form
    {
        #region  <DECLARACIONES>  

        //tabla para guardar los resultados de la consulta
        private DataTable _TblReport = new DataTable();

       


        #endregion

        #region  <PROPIEDADES>  
        
        public DataTable DataSources {
            set {
                _TblReport = value;
                GridReport.DataSource = value;
            }
        }
        public string ReportTitle {
            set {
                lblReportTitle.Text = "          " + value.ToUpper();
            }
        }

        #endregion


        public FRM_ReportView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TblReport.Columns.Count > 0) {
                _TblReport.TblToExcel();//exportamos el resultado a excel
            
            }
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

using MES;//nombre de espacio para guardar en excel

namespace PuntoDeVentas
{
    public partial class FRM_ReportView : Form
    {
        #region  <DECLARACIONES>  

        //tabla para guardar los resultados de la consulta
        private DataTable _TblReport = new DataTable();

       


        #endregion

        #region  <PROPIEDADES>  
        
        public DataTable DataSources {
            set {
                _TblReport = value;
                GridReport.DataSource = value;
            }
        }
        public string ReportTitle {
            set {
                lblReportTitle.Text = "          " + value.ToUpper();
            }
        }

        #endregion


        public FRM_ReportView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TblReport.Columns.Count > 0) {
                _TblReport.TblToExcel();//exportamos el resultado a excel
            
            }
        }
    }
}

>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
