using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace System {

    public partial class ArticuloItem : UserControl {

        private bool _bIsSelected = false;
        private int _Position = 0;
        private double _Cantidad = 0;
        private System.DbRepository.ArticuloInfo _Articulo;
        private bool _bIsDeleted = false;
        
        private void _SetSelectionColor() {

            if (this.IsSelected) {
                if (this.IsDeleted) {//Color de seleccion si el elemento esta marcado como eliminado
                    _SetDeletedColor();
                } else {
                    _SetSelectedColor();
                }
            } else {
                if (this.IsDeleted) {
                    _SetDeletedColor();
                } else {
                    _SetDefaultColor();
                }
            }
            this.Update();
        }

        private void _SetDefaultColor() {
            this.BackColor = System.Drawing.Color.FromArgb(24,24,24);

            Label1.ForeColor = Color.FromArgb(113, 113, 113);
            Label2.ForeColor = Color.FromArgb(113, 113, 113);
            Label3.ForeColor = Color.FromArgb(113, 113, 113);
            Label4.ForeColor = Color.FromArgb(113, 113, 113);


            lblArticulo.ForeColor = Color.WhiteSmoke;
            lblCantidad.ForeColor = Color.FromArgb(113, 113, 113);
            lblPrecio.ForeColor = Color.FromArgb(113, 113, 113);
            lblCodigo.ForeColor = Color.FromArgb(113, 113, 113);
            lblTotal.ForeColor = Color.FromArgb(113, 113, 113);
            lblEliminado.ForeColor = Color.FromArgb(113, 113, 113);
            lblSelectionLabel.BackColor = Color.FromArgb(113, 113, 113);
            
        }
        private void _SetSelectedColor() {
            this.BackColor = System.Drawing.Color.FromArgb(40,40,40);

            Label1.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            Label2.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            Label3.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            Label4.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);

            lblArticulo.ForeColor = System.Drawing.Color.FromArgb(6,94,43);
            lblCantidad.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            lblPrecio.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(6, 94, 43);
            lblSelectionLabel.BackColor = System.Drawing.Color.FromArgb(6, 94, 43);
                    
        }
        private void _SetDeletedColor() {

            if (this.IsSelected) {
                this.BackColor = System.Drawing.Color.Tomato;

                Label1.ForeColor = System.Drawing.Color.Maroon;
                Label2.ForeColor = System.Drawing.Color.Maroon;
                Label3.ForeColor = System.Drawing.Color.Maroon;
                Label4.ForeColor = System.Drawing.Color.Maroon;

                lblArticulo.ForeColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.Maroon;
                lblPrecio.ForeColor = System.Drawing.Color.Maroon;
                lblCodigo.ForeColor = System.Drawing.Color.Maroon;
                lblTotal.ForeColor = System.Drawing.Color.Maroon;
                lblEliminado.ForeColor = System.Drawing.Color.Maroon;
                lblSelectionLabel.BackColor = System.Drawing.Color.Maroon;

            } else {
                this.BackColor = System.Drawing.Color.Maroon;

                Label1.ForeColor = System.Drawing.Color.Red;
                Label2.ForeColor = System.Drawing.Color.Red;
                Label3.ForeColor = System.Drawing.Color.Red;
                Label4.ForeColor = System.Drawing.Color.Red;

                lblArticulo.ForeColor = System.Drawing.Color.Tomato;
                lblCantidad.ForeColor = System.Drawing.Color.Red;
                lblPrecio.ForeColor = System.Drawing.Color.Red;
                lblCodigo.ForeColor = System.Drawing.Color.Red;
                lblTotal.ForeColor = System.Drawing.Color.Red;
                lblEliminado.ForeColor = System.Drawing.Color.Red;
                lblSelectionLabel.BackColor = System.Drawing.Color.Red;
            }

        }

        public ArticuloItem(System.DbRepository.ArticuloInfo ArticuloItem, double Cantidad) {
            InitializeComponent();
            _SetDefaultColor();
            //Llenamos la informacion del articulo
            this.Update(ArticuloItem, Cantidad);
        }
               
        protected ArticuloItem() {
            InitializeComponent();
            _SetDefaultColor();
        }

        public bool IsSelected {
            get {
                return _bIsSelected;
            }
            set {
                _bIsSelected = value;
                lblSelectionLabel.Visible = value;
                _SetSelectionColor();                
            }
        }
        
        public int Position {
            get {//Guardamos la posicion que tiene en la lista despues que fue insertado
                return _Position;
            }
            set {
                _Position = value;
            }
        }

        public double Cantidad {
            get {
                return _Cantidad;
            }
        }

        public System.DbRepository.ArticuloInfo Articulo {

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
                _SetSelectionColor();
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
        public void Update(System.DbRepository.ArticuloInfo ArticuloItem, double Cantidad) {

            this._Cantidad = Cantidad;
            this._Articulo = ArticuloItem;

            lblArticulo.Text = _Articulo.DESCRIPCION;
            lblPrecio.Text = Double.Parse(_Articulo.PRECIO).ToString("$ 0.00");
            lblCodigo.Text = _Articulo.ID;
            lblTotal.Text = this.Total.ToString("$ 0.00");
            lblCantidad.Text = this.Cantidad.ToString("0.00 " + ArticuloItem.UNIDAD);

        }

        
        


    }
}
