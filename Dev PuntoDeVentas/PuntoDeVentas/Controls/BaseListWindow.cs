using System;
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
    public partial class BaseListWindow : Controls.BaseForm
    {
        private DataTable _DataSource;
        public BaseListWindow(String Title)
        {
            InitializeComponent();
            lblTile.Text = Title;

        }

        public DataTable DataSource {
            set {
                _DataSource = value;
                gridResults.DataSource = value;
            }
        }
        
        private void cmdExport_Click(object sender, EventArgs e)
        {
            _DataSource.TblToExcel();
        }

    }
}
