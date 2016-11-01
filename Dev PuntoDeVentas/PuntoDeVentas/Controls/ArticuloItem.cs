using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using PuntoDeVentas.Models;
using PuntoDeVentas;
namespace System {

    public partial class ArticuloItem : UserControl {

        private bool _bIsSelected = false;
        private int _Position = 0;
        private double _Cantidad = 0;
        private ArticuloInfo _Articulo;
        private bool _bIsDeleted = false;
        private Image _DefaultImg = null, _SelectedImg = null;

        public ArticuloItem(ArticuloInfo ArticuloItem, double Cantidad) {
            InitializeComponent();
            _SetDefaultFormat();
            //Llenamos la informacion del articulo
            this.Update(ArticuloItem, Cantidad);
        }

        public ArticuloItem() {
            InitializeComponent();
            //_SetDefaultFormat();

            if (this.DesignMode) {
                //CREAMOS UNA IMAGEN DUMMY SOLO CUANDO EL CONTROL ESTA EN MODO DISENO
                Size sz = this.picArticulo.Size;
                Graphics g;

                //REDUCIR EL TAMANO AL 50%
                sz.Width -= (int)(sz.Width * 0.5);
                sz.Height -= (int)(sz.Height * 0.5);

                _DefaultImg = new Bitmap(sz.Width, sz.Height);
                g = Graphics.FromImage(_DefaultImg);
                g.Clear(Color.White);

                this.picArticulo.Image = ImageInfo.GetRoundCornersImage(_DefaultImg, 5, this.BackColor);
            }




        }

        private void _RenderSelectionFormat() {
            this.SuspendLayout();

            if (this.IsSelected) {
                _SetSelectedFormat();

            } else {
                _SetDefaultFormat();
            }

            this.ResumeLayout();
        }

        private void _SetDefaultFormat() {

            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);

            Label1.ForeColor = Color.FromArgb(113, 113, 113);
            Label2.ForeColor = Color.FromArgb(113, 113, 113);
            Label3.ForeColor = Color.FromArgb(113, 113, 113);
            Label4.ForeColor = Color.FromArgb(113, 113, 113);

            lblNo.ForeColor = Color.WhiteSmoke;
            lblArticulo.ForeColor = Color.WhiteSmoke;
            lblCantidad.ForeColor = Color.FromArgb(113, 113, 113);
            lblPrecio.ForeColor = Color.FromArgb(113, 113, 113);
            lblCodigo.ForeColor = Color.FromArgb(113, 113, 113);
            lblTotal.ForeColor = Color.FromArgb(113, 113, 113);
            lblEliminado.ForeColor = Color.FromArgb(113, 113, 113);
            lblEliminado.Image = PuntoDeVentas.Properties.Resources.LabelHolder;

            //ESTABLECER LA IMAGEN X DEFAULT
            picArticulo.Image = _DefaultImg;

        }

        private void _SetSelectedFormat() {
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);

            lblNo.ForeColor = System.Drawing.Color.FromArgb(33, 190, 74);
            lblArticulo.ForeColor = System.Drawing.Color.FromArgb(33, 190, 74);
            lblEliminado.ForeColor = System.Drawing.Color.FromArgb(247, 243, 247);
            lblEliminado.Image = PuntoDeVentas.Properties.Resources.LabelHolderDarkGreen2;

            lblCantidad.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            lblPrecio.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);

            Label1.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            Label2.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            Label3.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);
            Label4.ForeColor = System.Drawing.Color.FromArgb(24, 142, 57);

            //ESTABLECER LA IMGEN SELECCIONADA
            picArticulo.Image = _SelectedImg;

        }

        public bool IsSelected {
            get {
                return _bIsSelected;
            }
            set {
                _bIsSelected = value;
                _RenderSelectionFormat();
            }
        }

        public int Position {
            get {//Guardamos la posicion que tiene en la lista despues que fue insertado
                return _Position;
            }
            set {
                _Position = value;
                lblNo.Text = (value + 1).ToString("00");
            }
        }

        public double Cantidad {
            get {
                return _Cantidad;
            }
        }

        public ArticuloInfo Articulo {

            get {
                return _Articulo;
            }
        }

        public bool IsDeleted {
            get {
                return _bIsDeleted;
            }
            set {

                _bIsDeleted = value;
                lblEliminado.Visible = value;
                _RenderSelectionFormat();
            }
        }

        public double Total {
            get {//Calcular el total en base precio y cantidad
                if (_Articulo.EXIST) {
                    return _Cantidad * double.Parse(_Articulo.PRECIO);
                } else {
                    return 0;
                }
            }
        }

        //Con esta funcion actualizamos la informacion del articulo
        public void Update(ArticuloInfo ArticuloItem, double Cantidad) {

            this._Cantidad = Cantidad;
            this._Articulo = ArticuloItem;

            lblArticulo.Text = _Articulo.DESCRIPCION;
            lblPrecio.Text = Functions.ToCurrency(_Articulo.PRECIO);
            lblCodigo.Text = _Articulo.ID;
            lblTotal.Text = Functions.ToCurrency(this.Total);
            lblCantidad.Text = this.Cantidad.ToString("0.00 " + ArticuloItem.UNIDAD);

            //OBTENER EL TAMANO DEL CONTROL
            var sz = this.picArticulo.Size;

            //REDUCIR EL TAMANO AL 50%
            sz.Width -= (int)(sz.Width * 0.5);
            sz.Height -= (int)(sz.Height * 0.5);

            //OBTENER LA IMAGEN EN ESCALA DE GRISES
            _DefaultImg = ImageInfo.GetRoundCornersImage(_Articulo.FOTO.GetGrayScaleImageSzOf(sz), 5, this.BackColor);
            //OBTENER LA IMAGEN EN COLOR
            _SelectedImg = ImageInfo.GetRoundCornersImage(_Articulo.FOTO.GetImageSzOf(sz), 5, this.BackColor);


        }

        private void lblEliminado_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {


        }
    }
}
