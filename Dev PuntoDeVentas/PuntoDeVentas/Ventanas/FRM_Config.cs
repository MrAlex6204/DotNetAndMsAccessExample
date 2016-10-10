using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {
    public partial class FRM_Config : Controls.BaseForm {
        public FRM_Config() {
            InitializeComponent();
        }

        private void FRM_Config_Load(object sender, EventArgs e) {
            txtNomNegocio.Text = System.Configurations.NombreDelNegocio;
            txtDireccion.Text = System.Configurations.Direccion;

            cmbRegion.DataSource = DbRepository.GetRegionList();
            cmbRegion.DisplayMember = "Country";
            cmbRegion.ValueMember = "Code";
            cmbRegion.SelectedValue = System.Configurations.RegionString;

        }

        private void cmdSave_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Desea guardar cambios ?", "Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

                System.Configurations.NombreDelNegocio = txtNomNegocio.Text;
                System.Configurations.Direccion = txtDireccion.Text;
                System.Configurations.RegionString = cmbRegion.SelectedValue.ToString();

                if (System.Configurations.Update()) {
                    Functions.Message("Cambios guardados exitosamente", Color.FromArgb(60, 184, 120), this);
                    System.Configurations.Load();//VOLVER A CARGAR LOS CAMBIOS PARA QUE SE ACTUALICE EL OBJETO DE REGION PROVIDER
                } else {
                    Functions.Message("No se pudo guardar los cambios realizados!", Color.FromArgb(192, 64, 0), this);
                }


            }


        }


    }
}
