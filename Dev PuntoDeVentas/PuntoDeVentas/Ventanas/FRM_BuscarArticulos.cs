using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {
    public partial class FRM_ConsultarArticulos : Controls.BaseForm {
        private string _ArticuloId = "";

        public FRM_ConsultarArticulos() {
            InitializeComponent();
        }

        public string ArticuloId {
            get {
                return _ArticuloId;
            }
        }

        private void Gridbuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
            }
        }

        private void FRM_ConsultarArticuloscs_Load(object sender, EventArgs e) {
            txtBuscar.Focus();
            txtBuscar.Text = "";
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e) {
            switch ((Keys)((int)e.KeyChar)) {

                case Keys.Enter:
                    if (txtBuscar.Focused) {
                        //SI EL CAMPO BUSCAR ESTA SELECCIONADO REALIZAR BUSQUEDA
                        Buscar(txtBuscar.Text);

                    } else if (Gridbuscar.Focused) {

                        if (Gridbuscar.Rows.Count > 0) {
                            //SELECCIONAR ARTICULO SI ESQUE HAY RESULTADOS EN EL GRID
                            SelectArticulo();
                        } else {
                            txtBuscar.Focus();//HACER FOCUS EN EL TXTBUSCAR
                            e.Handled = true;
                        }
                    } else {
                        txtBuscar.Focus();
                    }

                    break;
                case Keys.Down | Keys.Up:
                    Gridbuscar.Focus();
                    break;
                case Keys.Escape:
                    //INDICAMOS QUE EL USUARIO CANCELO
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                    break;
                default:
                    txtBuscar.Focus();
                    break;
            }
        }

        private void Buscar(string Buscar) {
            DataTable TblResults;

            TblResults = System.DbRepository.BuscarArticulo(Buscar.Trim());

            //AGREGAR LA COLUMNA FOTO AL TBL PARA GENERAR DE MANERA MANUAL EL THUBNAIL DE LA IMAGEN
            TblResults.Columns.Add("FOTO_IMAGE",typeof(Image));
            TblResults.AcceptChanges();

            if (TblResults.Rows.Count > 0) {

                var Sz = pictArticulo.Size;//OBTENEMOS EL SIZE DEL PICTUREBOX
                //Sz.Width -= (int)(Sz.Width * 0.5);
                //Sz.Height-= (int)(Sz.Height * 0.5);

                foreach (DataRow iRow in TblResults.Rows) {

                    //OBTENEMOS EL STREAM DE LA FOTO DEL VALOR DE LA CELDA QUE SE ENCUENTRA EN EL GRID
                    var Fs = iRow["FOTO"];
                    if (Fs != DBNull.Value) { 
                    //GENERAR FOTO Y GUARDAR EN LA COLUMNA FOTO_IMAGE
                        iRow["FOTO_IMAGE"] = ImageInfo.GetRoundCornersImage(ImageInfo.GetImageSzOf((byte[])Fs, Sz),5,this.BackColor);
                    }
                }
                


                //SELECCIONAR EL GRID SI HUBO RESULTADOS
                Gridbuscar.Focus();

            }
            

            //INDICARLE AL GRID LA TBL CON RESULTADOS
            Gridbuscar.DataSource = TblResults;

            foreach (DataGridViewColumn iColumn in Gridbuscar.Columns) {
                //INDICAR QUE LAS COLUMNAS NO SE VAN A PODER ORDENAR
                iColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                //OCULTAR LAS COLUMNAS QUE TENGAN COMO NOMBRE LA PALABRA FOTO
                if (iColumn.Name.Contains("FOTO")) {
                    iColumn.Visible = false;
                }

            }


        }

        private void SelectArticulo() {
            if (Gridbuscar.SelectedRows.Count > 0) {
                //GUARDAMOS EL CODIGO DEL ARTICULO SELECCIONADO, PARA DESPUES GUARDARLO
                _ArticuloId = Gridbuscar.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                //INDICAMOS QUE LA VENTANA SE CERRO ADECUADAMENTE
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void SelectedRow_Change(object sender, EventArgs e) {

            if (Gridbuscar.SelectedRows.Count > 0) {

                //OBTENEMOS LA FOTO DEL VALOR DE LA CELDA QUE SE ENCUENTRA EN EL GRID
                var Articulo_Image = Gridbuscar.SelectedRows[0].Cells["FOTO_IMAGE"].Value;

                if (Articulo_Image != DBNull.Value) {
                    pictArticulo.BackColor = Color.Transparent;
                    pictArticulo.Image = (Image)Articulo_Image;
                } else {
                    pictArticulo.Image = null;
                    pictArticulo.BackColor = Color.WhiteSmoke;
                }

            }


        }

    }
}
