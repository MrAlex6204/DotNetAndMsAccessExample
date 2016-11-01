using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PuntoDeVentas {
    public partial class FRM_Config : Controls.BaseForm {

        private ImageInfo UsrPic;

        public FRM_Config() {
            InitializeComponent();
        }

        private void FRM_Config_Load(object sender, EventArgs e) {
            LoadConfig();
            Configurations.ConfigChange += LoadConfig;

        }

        private void LoadConfig() { 
        
            txtNomNegocio.Text = System.Configurations.NombreDelNegocio;
            txtDireccion.Text = System.Configurations.Direccion;

            cmbRegion.DataSource = DbRepository.GetRegionList();
            cmbRegion.DisplayMember = "Country";
            cmbRegion.ValueMember = "Code";
            cmbRegion.SelectedValue = System.Configurations.RegionString;
            txtCajeroNombre.Text = DbRepository.LoggedUser.Name;
            lblUserName.Text = DbRepository.LoggedUser.UserName;
            UsrPic = DbRepository.LoggedUser.Picture;

            if (!UsrPic.IsEmpty) {
                picUser.Image = UsrPic.GetImageSzOf(picUser.Size).ConvertToGrayScale().GetTintImage(0f,0.36f,0f);//Convertir y obtener el Image del stream de la foto.            
            }
            
        
        }

        private void cmdSave_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Desea guardar cambios ?", "Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

                System.Configurations.NombreDelNegocio = txtNomNegocio.Text;
                System.Configurations.Direccion = txtDireccion.Text;
                System.Configurations.RegionString = cmbRegion.SelectedValue.ToString();

                var Usr = DbRepository.LoggedUser;

                Usr.Name = txtCajeroNombre.Text;
                Usr.Picture = UsrPic;

                if (DbRepository.GuardarUsuario(Usr) && System.Configurations.Update() ) {                    
                    Functions.Message("Cambios guardados exitosamente", Color.FromArgb(60, 184, 120), this);
                    System.Configurations.Load();//VOLVER A CARGAR LOS CAMBIOS PARA QUE SE ACTUALICE EL OBJETO DE REGION PROVIDER
                } else {
                    Functions.Message("No se pudo guardar los cambios realizados!", Color.FromArgb(192, 64, 0), this);
                }


            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            using (var dlg = new OpenFileDialog()) {
                dlg.Title = "Seleccione la foto de perfil";
                dlg.DefaultExt = "Jpeg|*.jpeg,Png|*.png";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK) {

                    UsrPic.FSImage = ImageInfo.GetFileStream(dlg.FileName);//Obtiene y guardar el Stream de la foto                    
                    picUser.Image = UsrPic.GetImageSzOf(picUser.Size).ConvertToGrayScale()                        
                        .GetTintImage(0f,0.36f,0);//Convertir y obtener el Image del stream de la foto.

                }
                
            }

        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbRegion.SelectedIndex > -1) {
                try {
                    var SelectedRegion = new CultureInfo(cmbRegion.SelectedValue.ToString()); 
                    var RegionInfo = new RegionInfo(SelectedRegion.LCID);
                    lblMoneda.Text = "Moneda : " + Functions.ToCurrency(0.00d, SelectedRegion) + " " + RegionInfo.ISOCurrencySymbol;                    

                } catch {
                    lblMoneda.Text = "Moneda : ";                
                }
            }
        }


    }
}
